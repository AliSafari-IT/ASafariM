using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace ASafariM.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        // logger
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(AppDbContext dbContext, ILogger<UserRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetUserByIdAsync(Guid userId)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            return user ?? throw new InvalidOperationException($"User with ID {userId} not found.");
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task AddUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            var existingUser = await _dbContext.Users.FindAsync(user.Id);
            if (existingUser == null)
            {
                throw new InvalidOperationException($"User with ID {user.Id} not found.");
            }

            // Copy updated values to existing entity
            _logger.LogInformation(
                "Updating user {UserId}. LastLogin before update: {LastLogin}",
                user.Id,
                existingUser.LastLogin
            );

            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.Email = user.Email;
            existingUser.UserName = user.UserName;
            existingUser.PhoneNumber = user.PhoneNumber;
            existingUser.PasswordHash = user.PasswordHash;
            existingUser.SecurityStamp = user.SecurityStamp;
            existingUser.ConcurrencyStamp = user.ConcurrencyStamp;
            existingUser.LastLogin = user.LastLogin;
            existingUser.FailedLoginAttempts = user.FailedLoginAttempts;
            existingUser.IsLockedOut = user.IsLockedOut;
            existingUser.LockoutEnd = user.LockoutEnd;

            _logger.LogInformation(
                "User {UserId} LastLogin after update: {LastLogin}",
                user.Id,
                existingUser.LastLogin
            );
            await _dbContext.SaveChangesAsync();
            _logger.LogInformation("Successfully saved changes for user {UserId}", user.Id);
        }

        public async Task UpdateUserByAdminAsync(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(Guid id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user == null)
            {
                throw new InvalidOperationException($"User with ID {id} not found.");
            }

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User?> GetUserByUserNameAsync(string userName)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<User?> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }

        public async Task<IEnumerable<UserRole>> GetRolesByUserIdAsync(Guid userId)
        {
            return await _dbContext
                .UserRoles.Where(ur => ur.UserId == userId)
                .Include(ur => ur.Role)
                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetUsersByUserNameOrEmailAsync(
            string? username,
            string? email
        )
        {
            var query = _dbContext.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(username))
            {
                query = query.Where(u => u.UserName.Contains(username));
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                query = query.Where(u => u.Email.Contains(email));
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<User>> GetUsersByRoleNameAsync(string roleName)
        {
            var users = await _dbContext
                .UserRoles.Where(ur => ur.Role.Name == roleName)
                .Include(ur => ur.User)
                .Select(ur => ur.User)
                .ToListAsync();

            return users;
        }

        public async Task AssignRolesToUserAsync(Guid userId, IEnumerable<Guid> roleIds)
        {
            var user = await _dbContext.Users.FindAsync(userId);
            if (user == null)
            {
                throw new InvalidOperationException($"User with ID {userId} not found.");
            }

            // First, verify that all roles exist
            var existingRoles = await _dbContext
                .Roles.Where(r => roleIds.Contains(r.Id))
                .Select(r => r.Id)
                .ToListAsync();

            var nonExistentRoles = roleIds.Except(existingRoles).ToList();
            if (nonExistentRoles.Any())
            {
                throw new InvalidOperationException(
                    $"The following role IDs do not exist: {string.Join(", ", nonExistentRoles)}"
                );
            }

            foreach (var roleId in roleIds)
            {
                // Check if the role already exists for the user
                var existingRole = await _dbContext.UserRoles.FirstOrDefaultAsync(ur =>
                    ur.UserId == userId && ur.RoleId == roleId
                );

                if (existingRole == null)
                {
                    _dbContext.UserRoles.Add(new UserRole { UserId = userId, RoleId = roleId });
                }
            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveRolesFromUserAsync(Guid userId, IEnumerable<Guid> roleIds)
        {
            var userRoles = await _dbContext
                .UserRoles.Where(ur => ur.UserId == userId && roleIds.Contains(ur.RoleId))
                .ToListAsync();

            if (userRoles.Any())
            {
                _dbContext.UserRoles.RemoveRange(userRoles);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> UserExistsAsync(Guid userId)
        {
            return await _dbContext.Users.AnyAsync(u => u.Id == userId);
        }

        public async Task<bool> UserExistsByUserNameAsync(string userName)
        {
            return await _dbContext.Users.AnyAsync(u => u.UserName == userName);
        }

        public async Task<bool> UserExistsByEmailAsync(string email)
        {
            return await _dbContext.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<bool> UserHasRoleAsync(Guid userId, Guid roleId)
        {
            return await _dbContext.UserRoles.AnyAsync(ur =>
                ur.UserId == userId && ur.RoleId == roleId
            );
        }

        public async Task<bool> UserHasRoleByAdminAsync(Guid userId, Guid roleId)
        {
            return await _dbContext.UserRoles.AnyAsync(ur =>
                ur.UserId == userId && ur.RoleId == roleId
            );
        }

        public async Task<bool> UserHasRoleByUserAsync(Guid userId, Guid roleId)
        {
            return await _dbContext.UserRoles.AnyAsync(ur =>
                ur.UserId == userId && ur.RoleId == roleId
            );
        }
    }

    public static class DbContextExtensions
    {
        public static bool IsInMemory(this DatabaseFacade database)
        {
            return database.ProviderName == "Microsoft.EntityFrameworkCore.InMemory";
        }
    }
}

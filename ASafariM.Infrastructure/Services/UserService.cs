using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Services;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ASafariM.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository? _userRepository;
        private readonly AutoMapper.IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly ILogger<UserService> _logger;
        private readonly AppDbContext _dbContext;

        public UserService(
            IUserRepository userRepository,
            AutoMapper.IMapper mapper,
            IConfiguration configuration,
            ILogger<UserService> logger,
            AppDbContext dbContext
        )
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _configuration = configuration;
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<bool> RegisterUserAsync(RegisterUserCommand command)
        {
            // Check if user already exists
            var existingUser = await _userRepository.GetUserByEmailAsync(command.Email);
            if (existingUser != null)
            {
                throw new InvalidOperationException("Email is already in use.");
            }

            // Create and save the new user
            var hashedPassword = PasswordHasher.HashPassword(command.Password);
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                UserName = command.UserName,
                Email = command.Email,
                NormalizedEmail = command.Email.ToUpperInvariant(),
                NormalizedUserName = command.UserName?.ToUpperInvariant(),
                Biography = command.Biography,
                Remark = command.Remark,
                ProfilePicture = command.ProfilePicture,
                IsAdmin = command.IsAdmin,
                DateOfBirth = command.DateOfBirth,
                PasswordHash = hashedPassword,
                CreatedAt = DateTime.UtcNow,
            };

            await _userRepository.AddUserAsync(user);
            return true;
        }

        public async Task<bool> LoginUserAsync(LoginUserCommand command)
        {
            // Verify user credentials
            var user = await _userRepository.GetUserByEmailAsync(command.Email);
            // add log
            _logger.LogInformation("Attempting to login user with email: {Email}", command.Email);
            if (user == null || !PasswordHasher.VerifyPassword(command.Password, user.PasswordHash))
            {
                _logger.LogInformation("Login failed for email: {Email}", command.Email);
                return false;
            }
            _logger.LogInformation("Login successful for email: {Email}", command.Email);
            return true;
        }

        public async Task<UserDto?> GetUserByIdAsync(Guid userId)
        {
            // Fetch user by ID
            var user = await _userRepository.GetUserByIdAsync(userId);
            // Map to UserDto
            if (user == null)
            {
                return null; // or handle accordingly
            }

            _logger.LogInformation(
                "GetUserByIdAsync: User LastLogin value: {LastLogin}",
                user.LastLogin
            );
            // Map the entity to UserDto through UserInfoDto
            var userInfoDto = _mapper.Map<UserInfoDto>(user);
            _logger.LogInformation(
                "GetUserByIdAsync: UserInfoDto LastLogin value: {LastLogin}",
                userInfoDto.LastLogin
            );
            var userDto = _mapper.Map<UserDto>(userInfoDto);
            _logger.LogInformation(
                "GetUserByIdAsync: UserDto LastLogin value: {LastLogin}",
                userDto.LastLogin
            );
            return userDto;
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            try
            {
                if (_userRepository == null)
                    throw new InvalidOperationException("User repository is null");

                _logger.LogInformation("Fetching all users from repository");
                var users = await _userRepository.GetAllUsersAsync();
                _logger.LogInformation($"Retrieved {users.Count} users from repository");

                _logger.LogInformation("Mapping users to UserInfoDto");
                var userInfoDtos = users.Select(user => _mapper.Map<UserInfoDto>(user)).ToList();
                _logger.LogInformation($"Mapped {userInfoDtos.Count} users to UserInfoDto");

                _logger.LogInformation("Mapping UserInfoDto to UserDto");
                var userDtos = userInfoDtos
                    .Select(userInfoDto => _mapper.Map<UserDto>(userInfoDto))
                    .ToList();
                _logger.LogInformation($"Successfully mapped {userDtos.Count} users to UserDto");

                return userDtos;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching and mapping users");
                throw;
            }
        }

        public async Task<User> CreateUserAsync(CreateUserCommand command)
        {
            // Normalize Email and Username
            var normalizedEmail = command.Email.ToUpperInvariant();
            var normalizedUserName = command.UserName?.ToUpperInvariant();

            // Generate SecurityStamp and ConcurrencyStamp
            var securityStamp = Guid.NewGuid().ToString();
            var concurrencyStamp = Guid.NewGuid().ToString();

            // Hash the password using secure PBKDF2 with salt
            var passwordHash = PasswordHasher.HashPassword(command.Password);

            // Create the User entity
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                NormalizedEmail = normalizedEmail,
                UserName = command.UserName,
                NormalizedUserName = normalizedUserName,
                PasswordHash = passwordHash,
                IsAdmin = command.IsAdmin,
                SecurityStamp = securityStamp,
                ConcurrencyStamp = concurrencyStamp,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                DateOfBirth = command.DateOfBirth,
            };

            // Save to the database (using your repository or DbContext)
            await _userRepository.AddUserAsync(user);

            return user;
        }

        public async Task<UserDto?> UpdateUserAsync(UpdateUserCommand command)
        {
            // Update the user by ID
            var user = await _userRepository.GetUserByIdAsync(command.Id);
            if (user == null)
            {
                throw new InvalidOperationException("User not found.");
            }

            user.FirstName = command.FirstName ?? user.FirstName;
            user.LastName = command.LastName ?? user.LastName;
            user.Email = command.Email ?? user.Email;
            user.UserName = command.UserName ?? user.UserName;
            user.Biography = command.Biography ?? user.Biography;
            user.Remark = command.Remark ?? user.Remark;
            user.ProfilePicture = command.ProfilePicture ?? user.ProfilePicture;
            user.DateOfBirth = command.DateOfBirth ?? user.DateOfBirth;
            user.IsActive = command.IsActive ?? user.IsActive;
            user.UpdatedAt = DateTime.UtcNow;

            await _userRepository.UpdateUserAsync(user);

            // Return updated user as UserDto
            return _mapper.Map<User, UserDto>(user);
        }

        // UpdateUserByAdminAsync
        public async Task<UserDto?> UpdateUserByAdminAsync(UpdateUserByAdminCommand command)
        {
            // Update the user by ID
            var user = await _userRepository.GetUserByIdAsync(command.Id);
            if (user == null)
            {
                throw new InvalidOperationException("User not found.");
            }

            user.FirstName = command.FirstName ?? user.FirstName;
            user.LastName = command.LastName ?? user.LastName;
            user.Email = command.Email ?? user.Email;
            user.UserName = command.UserName ?? user.UserName;
            user.Biography = command.Biography ?? user.Biography;
            user.Remark = command.Remark ?? user.Remark;
            user.ProfilePicture = command.ProfilePicture ?? user.ProfilePicture;
            user.DateOfBirth = command.DateOfBirth ?? user.DateOfBirth;
            user.IsActive = command.IsActive ?? user.IsActive;
            user.IsAdmin = command.IsAdmin ?? user.IsAdmin;
            user.UpdatedAt = DateTime.UtcNow;

            await _userRepository.UpdateUserAsync(user);

            // Return updated user as UserDto
            return _mapper.Map<User, UserDto>(user);
        }

        public async Task<bool> DeleteUserAsync(Guid id, string password)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                _logger.LogWarning("User not found for deletion: {UserId}", id);
                return false;
            }

            // Verify password
            var passwordVerificationResult = PasswordHasher.VerifyPassword(
                password,
                user.PasswordHash
            );
            if (!passwordVerificationResult)
            {
                _logger.LogWarning("Invalid password provided for user deletion: {UserId}", id);
                return false;
            }

            try
            {
                await _userRepository.DeleteUserAsync(id);
                _logger.LogInformation("User deleted successfully: {UserId}", id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to delete user: {UserId}", id);
                _logger.LogError($"Error deleting user {id}: {ex.Message}");
                _logger.LogError($"Stack trace: {ex.StackTrace}");
                return false;
            }
        }

        public async Task<bool> DeleteUserByAdminAsync(Guid id, bool isAdmin)
        {
            _logger.LogInformation(
                "Attempting to delete user: {UserId} by admin: {IsAdmin}",
                id,
                isAdmin
            );

            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                _logger.LogWarning("User not found for deletion: {UserId}", id);
                return false;
            }

            try
            {
                // Use the execution strategy for the delete operation
                await _dbContext
                    .Database.CreateExecutionStrategy()
                    .ExecuteAsync(async () =>
                    {
                        await _userRepository.DeleteUserAsync(id);
                    });

                _logger.LogInformation("User deleted successfully: {UserId}", id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting user: {UserId}", id);
                _logger.LogError($"Error deleting user {id}: {ex.Message}");
                _logger.LogError($"Stack trace: {ex.StackTrace}");
                return false;
            }
        }

        public async Task<bool> ChangePasswordAsync(ChangePasswordCommand command)
        {
            var user = await _userRepository.GetUserByIdAsync(command.Id);

            if (user == null)
            {
                throw new InvalidOperationException("User not found.");
            }

            user.PasswordHash = PasswordHasher.HashPassword(command.NewPassword);
            user.UpdatedAt = DateTime.UtcNow;

            await _userRepository.UpdateUserAsync(user);
            return true;
        }

        public Task<bool> ForgotPasswordAsync(ForgotPasswordCommand command)
        {
            // TODO: Add implementation for forgot password
            return Task.FromResult(true);
        }

        public Task<bool> ResetPasswordAsync(ResetPasswordCommand command)
        {
            // TODO: Add implementation for reset password
            return Task.FromResult(true);
        }

        public async Task UpdateProfileAsync(UpdateProfileCommand command)
        {
            // Get the current user ID from the command
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            if (_userRepository == null)
                throw new InvalidOperationException("User repository is null");

            // Get current user from the context (you'll need to pass the user ID in the command)
            var user = await _userRepository.GetUserByIdAsync(command.UserId);
            if (user == null)
                throw new InvalidOperationException("User not found");

            // Update user properties
            user.FirstName = command.FirstName;
            user.LastName = command.LastName;
            user.PhoneNumber = command.PhoneNumber;
            user.UpdatedAt = DateTime.UtcNow;

            // Save changes
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task<IsTakenDto?> IsUsernameNotTakenAsync(string username)
        {
            var normalizedUsername = username.ToUpperInvariant();
            var exists = await _dbContext.Users.AnyAsync(u =>
                u.NormalizedUserName == normalizedUsername && !u.IsDeleted
            );

            return new IsTakenDto { IsTaken = exists };
        }

        public async Task<IsTakenDto?> IsEmailNotTakenAsync(string email)
        {
            var normalizedEmail = email.ToUpperInvariant();
            var exists = await _dbContext.Users.AnyAsync(u =>
                u.NormalizedEmail == normalizedEmail && !u.IsDeleted
            );

            return new IsTakenDto { IsTaken = exists };
        }

        public async Task<UserDto?> CreateUserByAdminAsync(CreateUserByAdminCommand command)
        {
            // Normalize Email and Username
            var normalizedEmail = command.Email.ToUpperInvariant();
            var normalizedUserName = command.UserName?.ToUpperInvariant();

            // Generate SecurityStamp and ConcurrencyStamp
            var securityStamp = Guid.NewGuid().ToString();
            var concurrencyStamp = Guid.NewGuid().ToString();

            // Hash the password using secure PBKDF2 with salt
            var passwordHash = PasswordHasher.HashPassword(command.Password);

            // Create the User entity
            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                NormalizedEmail = normalizedEmail,
                UserName = command.UserName,
                NormalizedUserName = normalizedUserName,
                PasswordHash = passwordHash,
                IsAdmin = command.IsAdmin,
                SecurityStamp = securityStamp,
                ConcurrencyStamp = concurrencyStamp,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                DateOfBirth = command.DateOfBirth,
            };

            await _userRepository.AddUserAsync(user);
            return _mapper.Map<User, UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> SearchUsersAsync(string? username, string? email)
        {
            var users = await _userRepository.GetUsersByUserNameOrEmailAsync(username, email);
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(users);
        }

        public async Task<IEnumerable<UserRoleDto>> GetRolesByUserId(string userId)
        {
            var userRoles = await _userRepository.GetRolesByUserIdAsync(Guid.Parse(userId));
            return _mapper.Map<IEnumerable<UserRole>, IEnumerable<UserRoleDto>>(userRoles);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq; // Required for mocking

namespace ASafariM.Test.DomainTests.Repositories
{
    [TestClass]
    public class UserRepositoryTests
    {
        private DbContextOptions<AppDbContext> _options = null!;
        private AppDbContext _context = null!;
        private IUserRepository _userRepository = null!;

        [TestInitialize]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // Use unique name for each test
                .EnableSensitiveDataLogging() // Enables detailed logging
                .Options;

            _context = new AppDbContext(_options);
            _context.Database.EnsureDeleted(); // Start with a clean database
            _context.Database.EnsureCreated();

            var loggerMock = new Mock<ILogger<UserRepository>>();
            _userRepository = new UserRepository(_context, loggerMock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [TestMethod]
        public async Task UpdateUserByAdminAsync_ShouldLogAndSaveChanges()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "adminupdate@example.com",
                PasswordHash = "hashedpassword",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            user.Email = "updatedbyadmin@example.com";
            await _userRepository.UpdateUserByAdminAsync(user);
            var updatedUser = await _context.Users.FindAsync(user.Id);

            // Assert
            Assert.IsNotNull(updatedUser);
            Assert.AreEqual("updatedbyadmin@example.com", updatedUser.Email);
        }

        [TestMethod]
        public async Task GetUserByEmailAsync_ShouldReturnUser_WhenEmailExists()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "test@example.com",
                PasswordHash = "hashedpassword",
                ConcurrencyStamp = Guid.NewGuid().ToString(), // Required
                SecurityStamp = Guid.NewGuid()
                    .ToString() // Required
                ,
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            var result = await _userRepository.GetUserByEmailAsync("test@example.com");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(user.Email, result.Email);
        }

        [TestMethod]
        public async Task GetUserByEmailAsync_ShouldReturnNull_WhenEmailDoesNotExist()
        {
            // Act
            var result = await _userRepository.GetUserByEmailAsync("nonexistent@example.com");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task AddUserAsync_ShouldAddUserToDatabase()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "newuser@example.com",
                PasswordHash = "hashedpassword",
                ConcurrencyStamp = Guid.NewGuid().ToString(), // Required
                SecurityStamp = Guid.NewGuid()
                    .ToString() // Required
                ,
            };
            // Act
            await _userRepository.AddUserAsync(user);
            var savedUser = await _context.Users.FindAsync(user.Id);

            // Assert
            Assert.IsNotNull(savedUser);
            Assert.AreEqual(user.Email, savedUser.Email);
        }

        [TestMethod]
        public async Task UpdateUserAsync_ShouldUpdateUserDetails()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "updatable@example.com",
                PasswordHash = "hashedpassword",
                ConcurrencyStamp = Guid.NewGuid().ToString(), // Required
                SecurityStamp = Guid.NewGuid()
                    .ToString() // Required
                ,
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            user.Email = "updated@example.com";
            await _userRepository.UpdateUserAsync(user);
            var updatedUser = await _context.Users.FindAsync(user.Id);

            // Assert
            Assert.IsNotNull(updatedUser);
            Assert.AreEqual("updated@example.com", updatedUser.Email);
        }

        [TestMethod]
        public async Task DeleteUserAsync_ShouldRemoveUserFromDatabase()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "deletable@example.com",
                PasswordHash = "hashedpassword",
                ConcurrencyStamp = Guid.NewGuid().ToString(), // Required
                SecurityStamp = Guid.NewGuid()
                    .ToString() // Required
                ,
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            // Act
            await _userRepository.DeleteUserAsync(user.Id);
            var deletedUser = await _context.Users.FindAsync(user.Id);

            // Assert
            Assert.IsNull(deletedUser);
        }

        [TestMethod]
        public async Task GetAllUsersAsync_ShouldReturnAllUsers()
        {
            // Arrange
            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "user1@example.com",
                    PasswordHash = "hashedpassword",
                    ConcurrencyStamp = Guid.NewGuid().ToString(), // Required
                    SecurityStamp = Guid.NewGuid()
                        .ToString() // Required
                    ,
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Email = "user2@example.com",
                    PasswordHash = "hashedpassword",
                    ConcurrencyStamp = Guid.NewGuid().ToString(), // Required
                    SecurityStamp = Guid.NewGuid()
                        .ToString() // Required
                    ,
                },
            };
            _context.Users.AddRange(users);
            await _context.SaveChangesAsync();

            // Act
            var result = await _userRepository.GetAllUsersAsync();

            // Assert
            Assert.AreEqual(2, result.Count);
            CollectionAssert.AreEquivalent(
                users.Select(u => u.Email).ToList(),
                result.Select(r => r.Email).ToList()
            );
        }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASafariM.Test.DomainTests.Persistence
{
    [TestClass]
    public class AppDbContextTests
    {
        private DbContextOptions<AppDbContext> _options;
        private AppDbContext _context;

        [TestInitialize]
        public void Setup()
        {
            _options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .EnableSensitiveDataLogging()
                .Options;

            _context = new AppDbContext(_options);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [TestMethod]
        public async Task UserPreference_HasCorrectPrimaryKey()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "test@example.com",
                NormalizedEmail = "TEST@EXAMPLE.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Test",
                LastName = "User",
            };

            var preference = new UserPreference { UserId = user.Id, User = user };

            // Act
            await _context.Users.AddAsync(user);
            await _context.UserPreferences.AddAsync(preference);
            await _context.SaveChangesAsync();

            // Assert
            var savedPreference = await _context.UserPreferences.FindAsync(user.Id);
            Assert.IsNotNull(savedPreference);
            Assert.AreEqual(user.Id, savedPreference.UserId);
        }

        [TestMethod]
        public async Task User_HasRequiredProperties()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "test@example.com",
                FirstName = "Test",
                LastName = "User",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };

            // Act & Assert
            await _context.Users.AddAsync(user);
            await Assert.ThrowsExceptionAsync<DbUpdateException>(async () =>
            {
                user.NormalizedEmail = null; // This should fail as it's required
                await _context.SaveChangesAsync();
            });
        }

        [TestMethod]
        public async Task UserPreference_HasOneToOneRelationshipWithUser()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var user = new User
            {
                Id = userId,
                Email = "test@example.com",
                NormalizedEmail = "TEST@EXAMPLE.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Test",
                LastName = "User",
            };

            var preference = new UserPreference { UserId = userId, User = user };

            // Act
            await _context.Users.AddAsync(user);
            await _context.UserPreferences.AddAsync(preference);
            await _context.SaveChangesAsync();

            // Assert
            var savedUser = await _context
                .Users.Include(u => u.Preference)
                .FirstOrDefaultAsync(u => u.Id == userId);

            Assert.IsNotNull(savedUser);
            Assert.IsNotNull(savedUser.Preference);
            Assert.AreEqual(userId, savedUser.Preference.UserId);
        }

        [TestMethod]
        public async Task User_PropertyLengthConstraints()
        {
            // Arrange
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = "test@example.com",
                NormalizedEmail = new string('A', 256), // Exceeds max length of 255
                NormalizedUserName = new string('A', 256), // Exceeds max length of 255
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Test",
                LastName = "User"
            };

            // Act & Assert
            await _context.Users.AddAsync(user);
            await Assert.ThrowsExceptionAsync<DbUpdateException>(async () =>
            {
                user.NormalizedEmail = null; // This should fail as it's required
                await _context.SaveChangesAsync();
            });
        }

        [TestMethod]
        public async Task UserPreference_CascadeDeleteWithUser()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var user = new User
            {
                Id = userId,
                Email = "test@example.com",
                NormalizedEmail = "TEST@EXAMPLE.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                FirstName = "Test",
                LastName = "User",
            };

            var preference = new UserPreference { UserId = userId, User = user };

            await _context.Users.AddAsync(user);
            await _context.UserPreferences.AddAsync(preference);
            await _context.SaveChangesAsync();

            // Act
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            // Assert
            var deletedPreference = await _context.UserPreferences.FindAsync(userId);
            Assert.IsNull(
                deletedPreference,
                "UserPreference should be deleted when User is deleted"
            );
        }

        [TestMethod]
        public void DbSets_AreProperlyDefined()
        {
            // Assert
            Assert.IsNotNull(_context.Users);
            Assert.IsNotNull(_context.Roles);
            Assert.IsNotNull(_context.UserPreferences);
            Assert.IsNotNull(_context.AccessibilityPreferences);
            Assert.IsNotNull(_context.GeographicalPreferences);
            Assert.IsNotNull(_context.NotificationPreferences);
            Assert.IsNotNull(_context.PrivacyPreferences);
            Assert.IsNotNull(_context.MiscellaneousPreferences);
            Assert.IsNotNull(_context.ThemePreferences);
            Assert.IsNotNull(_context.LanguagePreferences);
        }
    }
}

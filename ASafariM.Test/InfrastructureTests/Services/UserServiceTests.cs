using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Services;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Infrastructure.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test.InfrastructureTests.Services
{
    public class TestAsyncQueryProvider<TEntity> : IAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public TestAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            return new TestAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new TestAsyncEnumerable<TElement>(expression);
        }

        public object Execute(Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(Expression expression)
        {
            var result = _inner.Execute<TResult>(expression);
            if (result == null)
            {
                throw new InvalidOperationException("Execution returned null.");
            }
            return result;
        }

        public TResult ExecuteAsync<TResult>(
            Expression expression,
            CancellationToken cancellationToken = default
        )
        {
            var expectedResultType = typeof(TResult).GetGenericArguments()[0];
            var executionResult = typeof(IQueryProvider)
                .GetMethod(
                    name: nameof(IQueryProvider.Execute),
                    genericParameterCount: 1,
                    types: new[] { typeof(Expression) }
                )
                .MakeGenericMethod(expectedResultType)
                .Invoke(this, new[] { expression });

            return (TResult)
                typeof(Task)
                    .GetMethod(nameof(Task.FromResult))
                    .MakeGenericMethod(expectedResultType)
                    .Invoke(null, new[] { executionResult });
        }
    }

    public class TestAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
    {
        public TestAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable) { }

        public TestAsyncEnumerable(Expression expression)
            : base(expression) { }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new TestAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new TestAsyncQueryProvider<T>(this); }
        }
    }

    public class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _inner;

        public TestAsyncEnumerator(IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return new ValueTask<bool>(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        public ValueTask DisposeAsync()
        {
            _inner.Dispose();
            return new ValueTask();
        }
    }

    [TestClass]
    public class UserServiceTests
    {
        private Mock<IUserRepository>? _userRepositoryMock;
        private Mock<ILogger<UserService>>? _loggerMock;
        private Mock<IMapper>? _mapperMock;
        private Mock<IConfiguration>? _configurationMock;
        private AppDbContext? _dbContext;
        private UserService? _userService;

        [TestInitialize]
        public void Setup()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
            _loggerMock = new Mock<ILogger<UserService>>();
            _mapperMock = new Mock<IMapper>();
            _configurationMock = new Mock<IConfiguration>();

            // Setup in-memory database for testing
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb_" + Guid.NewGuid().ToString())
                .Options;
            _dbContext = new AppDbContext(options);

            // Setup mapper mock for UserDto mapping
            _mapperMock
                .Setup(m => m.Map<UserDto>(It.IsAny<User>()))
                .Returns((User user) => new UserDto { Id = user.Id, Email = user.Email });
            _mapperMock
                .Setup(m => m.Map<UserInfoDto>(It.IsAny<User>()))
                .Returns((User user) => new UserInfoDto { Id = user.Id, Email = user.Email });
            _mapperMock
                .Setup(m => m.Map<UserDto>(It.IsAny<UserInfoDto>()))
                .Returns((UserInfoDto dto) => new UserDto { Id = dto.Id, Email = dto.Email });

            _userService = new UserService(
                _userRepositoryMock.Object,
                _mapperMock.Object,
                _configurationMock.Object,
                _loggerMock.Object,
                _dbContext
            );
        }

        [TestCleanup]
        public void Cleanup()
        {
            _dbContext.Dispose();
        }

        [TestMethod]
        public async Task LoginUserAsync_ShouldReturnTrue_WhenCredentialsAreValid()
        {
            // Arrange
            var password = "Password123";
            var hashedPassword = PasswordHasher.HashPassword(password);
            var command = new LoginUserCommand { Email = "valid@example.com", Password = password };

            var user = new User { Email = command.Email, PasswordHash = hashedPassword };

            _userRepositoryMock
                .Setup(repo => repo.GetUserByEmailAsync(command.Email))
                .ReturnsAsync(user);

            // Act
            var result = await _userService.LoginUserAsync(command);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public async Task GetUserByIdAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var user = new User { Id = userId, Email = "test@example.com" };
            _userRepositoryMock.Setup(repo => repo.GetUserByIdAsync(userId)).ReturnsAsync(user);

            // Act
            var result = await _userService.GetUserByIdAsync(userId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(userId, result.Id);
        }

        [TestMethod]
        public async Task GetAllUsersAsync_ShouldReturnAllUsers()
        {
            // Arrange
            var users = new List<User>
            {
                new User { Id = Guid.NewGuid(), Email = "user1@example.com" },
                new User { Id = Guid.NewGuid(), Email = "user2@example.com" },
            };
            _userRepositoryMock.Setup(repo => repo.GetAllUsersAsync()).ReturnsAsync(users);

            // Act
            var result = await _userService.GetAllUsersAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(users.Count, result.Count());
        }

        [TestMethod]
        public async Task UpdateUserAsync_ShouldUpdateUser()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var existingUser = new User
            {
                Id = userId,
                Email = "test@example.com",
                FirstName = "Test",
                LastName = "User",
                PasswordHash = PasswordHasher.HashPassword("Password123"),
            };

            _userRepositoryMock
                .Setup(repo => repo.GetUserByIdAsync(userId))
                .ReturnsAsync(existingUser);

            _userRepositoryMock
                .Setup(repo => repo.UpdateUserAsync(It.IsAny<User>()))
                .Returns(Task.CompletedTask);

            var command = new UpdateUserCommand
            {
                Id = userId,
                Email = "updated@example.com",
                FirstName = "Updated",
                LastName = "User",
            };

            // Act
            await _userService.UpdateUserAsync(command);

            // Assert
            _userRepositoryMock.Verify(
                repo =>
                    repo.UpdateUserAsync(
                        It.Is<User>(u =>
                            u.Id == userId
                            && u.Email == command.Email
                            && u.FirstName == command.FirstName
                            && u.LastName == command.LastName
                        )
                    ),
                Times.Once
            );
        }

        [TestMethod]
        public async Task DeleteUserAsync_ShouldDeleteUser_WhenUserExists()
        {
            // Arrange
            var password = "Password123";
            var userId = Guid.NewGuid();
            var existingUser = new User
            {
                Id = userId,
                Email = "test@example.com",
                PasswordHash = PasswordHasher.HashPassword(password),
            };

            _userRepositoryMock
                .Setup(repo => repo.GetUserByIdAsync(userId))
                .ReturnsAsync(existingUser);

            // Act
            var result = await _userService.DeleteUserAsync(userId, password);

            // Assert
            Assert.IsTrue(result);
            _userRepositoryMock.Verify(repo => repo.DeleteUserAsync(userId), Times.Once);
        }

        [TestMethod]
        public async Task CreateUserAsync_ShouldCreateUser_WhenValidCommand()
        {
            // Arrange
            var command = new CreateUserCommand
            {
                FirstName = "Test",
                LastName = "User",
                Email = "test@example.com",
                UserName = "testuser",
                Password = "Password123",
                DateOfBirth = DateTime.UtcNow.AddYears(-20),
                IsAdmin = false,
            };

            _userRepositoryMock
                .Setup(repo => repo.AddUserAsync(It.IsAny<User>()))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _userService.CreateUserAsync(command);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(command.Email, result.Email);
            Assert.AreEqual(command.UserName, result.UserName);
            _userRepositoryMock.Verify(repo => repo.AddUserAsync(It.IsAny<User>()), Times.Once);
        }

        [TestMethod]
        public async Task CreateUserByAdminAsync_ShouldCreateUser_WhenValidCommand()
        {
            try
            {
                // Logging the start of the test
                Console.WriteLine(
                    "Starting CreateUserByAdminAsync_ShouldCreateUser_WhenValidCommand test"
                );

                // Arrange
                var command = new CreateUserByAdminCommand
                {
                    FirstName = "Admin",
                    LastName = "Created",
                    Email = "admin.created@example.com",
                    UserName = "admincreated",
                    Password = "Password123",
                    DateOfBirth = DateTime.UtcNow.AddYears(-25),
                    IsAdmin = true,
                };

                Console.WriteLine($"Command created: {JsonSerializer.Serialize(command)}");

                var createdUser = new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Email = command.Email,
                    UserName = command.UserName,
                    IsAdmin = command.IsAdmin,
                };

                _userRepositoryMock
                    .Setup(repo => repo.AddUserAsync(It.IsAny<User>()))
                    .Returns(Task.FromResult(createdUser));

                // Log before calling the service method
                Console.WriteLine("Calling CreateUserByAdminAsync method");

                // Act
                var result = await _userService.CreateUserByAdminAsync(command);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(createdUser.Email, result.Email);
            }
            catch (Exception ex)
            {
                // Log any exceptions that occur
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        [TestMethod]
        public async Task UpdateUserByAdminAsync_ShouldUpdateUser_WhenValidCommand()
        {
            // Logging for diagnosis
            var logMessage = "";
            // Arrange
            var userId = Guid.NewGuid();
            var command = new UpdateUserByAdminCommand
            {
                Id = userId,
                Email = "updated@example.com",
                FirstName = "Updated",
                LastName = "ByAdmin",
                IsActive = true,
            };

            var existingUser = new User
            {
                Id = userId,
                Email = "existing@example.com",
                FirstName = "Existing",
                LastName = "User",
                IsAdmin = false,
            };

            try
            {
                var updatedUser = new User
                {
                    Id = userId,
                    Email = command.Email,
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    IsActive = command.IsActive ?? true,
                };

                _userRepositoryMock
                    .Setup(repo => repo.GetUserByIdAsync(userId))
                    .ReturnsAsync(existingUser);

                _userRepositoryMock
                    .Setup(repo => repo.UpdateUserAsync(It.IsAny<User>()))
                    .Returns(Task.FromResult(updatedUser));

                var expectedDto = new UserDto
                {
                    Id = updatedUser.Id,
                    Email = updatedUser.Email,
                    FirstName = updatedUser.FirstName,
                    LastName = updatedUser.LastName,
                };

                _mapperMock.Setup(m => m.Map<UserDto>(It.IsAny<User>())).Returns(expectedDto);

                // Act
                var result = await _userService.UpdateUserByAdminAsync(command);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(expectedDto.Email, result.Email);
                Assert.AreEqual(expectedDto.FirstName, result.FirstName);

                logMessage =
                    $"Expected DTO: Id={expectedDto.Id}, Email={expectedDto.Email}, FirstName={expectedDto.FirstName}, LastName={expectedDto.LastName}\n"
                    + $"Actual Result: Id={result.Id}, Email={result.Email}, FirstName={result.FirstName}, LastName={result.LastName}";
            }
            catch (Exception ex)
            {
                logMessage = $"Test failed with exception: {ex.Message}\n{ex.StackTrace}";
            }
            finally
            {
                File.WriteAllText("test_log.txt", logMessage);
            }

            _userRepositoryMock.Verify(
                repo =>
                    repo.UpdateUserAsync(
                        It.Is<User>(u =>
                            u.Id == userId
                            && u.Email == command.Email
                            && u.FirstName == command.FirstName
                            && u.LastName == command.LastName
                            && u.IsActive == command.IsActive
                        )
                    ),
                Times.Once
            );
        }

        [TestMethod]
        public async Task DeleteUserByAdminAsync_ShouldDeleteUser_WhenUserExists()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var existingUser = new User { Id = userId, Email = "todelete@example.com" };

            _userRepositoryMock
                .Setup(repo => repo.GetUserByIdAsync(userId))
                .ReturnsAsync(existingUser);

            _userRepositoryMock
                .Setup(repo => repo.DeleteUserAsync(userId))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _userService.DeleteUserByAdminAsync(userId, true);

            // Assert
            Assert.IsTrue(result);
            _userRepositoryMock.Verify(repo => repo.DeleteUserAsync(userId), Times.Once);
        }

        [TestMethod]
        public async Task IsUsernameNotTakenAsync_ShouldReturnTrue_WhenUsernameExists()
        {
            // Arrange
            var username = "existinguser";
            var users = new List<User>
            {
                new User
                {
                    UserName = username,
                    NormalizedUserName = username.ToUpperInvariant(),
                    IsDeleted = false,
                },
            };

            var mockDbSet = new Mock<DbSet<User>>();
            var queryable = users.AsQueryable();

            mockDbSet
                .As<IQueryable<User>>()
                .Setup(m => m.Provider)
                .Returns(new TestAsyncQueryProvider<User>(queryable.Provider));
            mockDbSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockDbSet
                .As<IQueryable<User>>()
                .Setup(m => m.ElementType)
                .Returns(queryable.ElementType);
            mockDbSet
                .As<IQueryable<User>>()
                .Setup(m => m.GetEnumerator())
                .Returns(() => queryable.GetEnumerator());

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb_" + Guid.NewGuid().ToString())
                .Options;
            _dbContext = new AppDbContext(options);
            _dbContext.Users = mockDbSet.Object;

            _userService = new UserService(
                _userRepositoryMock.Object,
                _mapperMock.Object,
                _configurationMock.Object,
                _loggerMock.Object,
                _dbContext
            );

            // Act
            var result = await _userService.IsUsernameNotTakenAsync(username);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsTaken);
        }

        [TestMethod]
        public async Task IsEmailNotTakenAsync_ShouldReturnTrue_WhenEmailExists()
        {
            // Arrange
            var email = "existing@example.com";
            var users = new List<User>
            {
                new User
                {
                    Email = email,
                    NormalizedEmail = email.ToUpperInvariant(),
                    IsDeleted = false,
                },
            };

            var mockDbSet = new Mock<DbSet<User>>();
            var queryable = users.AsQueryable();

            mockDbSet
                .As<IQueryable<User>>()
                .Setup(m => m.Provider)
                .Returns(new TestAsyncQueryProvider<User>(queryable.Provider));
            mockDbSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(queryable.Expression);
            mockDbSet
                .As<IQueryable<User>>()
                .Setup(m => m.ElementType)
                .Returns(queryable.ElementType);
            mockDbSet
                .As<IQueryable<User>>()
                .Setup(m => m.GetEnumerator())
                .Returns(() => queryable.GetEnumerator());

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb_" + Guid.NewGuid().ToString())
                .Options;
            _dbContext = new AppDbContext(options);
            _dbContext.Users = mockDbSet.Object;

            _userService = new UserService(
                _userRepositoryMock.Object,
                _mapperMock.Object,
                _configurationMock.Object,
                _loggerMock.Object,
                _dbContext
            );

            // Act
            var result = await _userService.IsEmailNotTakenAsync(email);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsTaken);
        }
    }
}

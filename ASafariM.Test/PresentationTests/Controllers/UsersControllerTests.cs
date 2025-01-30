using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Services;
using ASafariM.Presentation.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASafariM.Test.PresentationTests.Controllers
{
    [TestClass]
    public class UsersControllerTests
    {
        private Mock<IUserService> _userServiceMock;
        private Mock<ILogger<UsersController>> _loggerMock;
        private Mock<IMapper> _mapperMock;
        private UsersController _controller;

        [TestInitialize]
        public void Setup()
        {
            _userServiceMock = new Mock<IUserService>();
            _loggerMock = new Mock<ILogger<UsersController>>();
            _mapperMock = new Mock<IMapper>();
            _controller = new UsersController(
                _userServiceMock.Object,
                _loggerMock.Object,
                _mapperMock.Object
            );
        }

        [TestMethod]
        public async Task GetAllUsers_ReturnsOkWithUsers()
        {
            // Arrange
            var users = new List<UserDto>
            {
                new UserDto { Id = Guid.NewGuid(), UserName = "user1" },
                new UserDto { Id = Guid.NewGuid(), UserName = "user2" },
            };
            _userServiceMock.Setup(s => s.GetAllUsersAsync()).ReturnsAsync(users);

            // Act
            var result = await _controller.GetAllUsers() as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            CollectionAssert.AreEqual(users, (List<UserDto>)result.Value);
        }

        [TestMethod]
        public async Task CreateUser_ValidCommand_ReturnsCreated()
        {
            // Arrange
            var command = new CreateUserCommand
            {
                UserName = "newUser",
                Password = "Password123!",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
            };

            var createdUser = new Domain.Entities.User
            {
                Id = Guid.NewGuid(),
                UserName = command.UserName,
            };
            _userServiceMock.Setup(s => s.CreateUserAsync(command)).ReturnsAsync(createdUser);

            // Act
            var result = await _controller.CreateUser(command) as CreatedAtActionResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(nameof(_controller.GetAllUsers), result.ActionName);
        }

        [TestMethod]
        public async Task CreateUser_InvalidCommand_ReturnsBadRequest()
        {
            // Arrange
            var command = new CreateUserCommand
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                UserName = "johndoe",
                Password = "password123",
            };
            _controller.ModelState.AddModelError("Username", "Required");

            // Act
            var result = await _controller.CreateUser(command) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
        }

        [TestMethod]
        public async Task UpdateUser_UserNotFound_ReturnsNotFound()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var command = new UpdateUserCommand { Id = userId, UserName = "updatedUser" };
            _userServiceMock.Setup(s => s.UpdateUserAsync(command)).ReturnsAsync((UserDto)null);

            // Act
            var result = await _controller.UpdateUser(userId, command) as NotFoundResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
        }

        [TestMethod]
        public async Task DeleteUser_UserNotFound_ReturnsNotFound()
        {
            // Arrange
            var id = Guid.NewGuid();
            var command = new DeleteUserCommand { Password = "Password123!" };
            _userServiceMock
                .Setup(s => s.DeleteUserAsync(id, command.Password))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.DeleteUser(id, command) as NotFoundObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
        }

        [TestMethod]
        public async Task GetUserById_UserExists_ReturnsOkWithUser()
        {
            // Arrange
            var id = Guid.NewGuid();
            var user = new UserDto { Id = id, UserName = "existingUser" };
            _userServiceMock.Setup(s => s.GetUserByIdAsync(id)).ReturnsAsync(user);

            // Act
            var result = await _controller.GetUserById(id);
            var okResult = result.Result as OkObjectResult;

            // Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual(user, okResult.Value);
        }

        [TestMethod]
        public async Task CheckAvailability_UsernameTaken_ReturnsMessages()
        {
            // Arrange
            var username = "existingUser";
            _userServiceMock
                .Setup(s => s.IsUsernameNotTakenAsync(username))
                .ReturnsAsync(new IsTakenDto { IsTaken = true });

            // Act
            var actionResult = await _controller.CheckAvailability(username: username);
            var result = actionResult.Result as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);

            var response = result.Value as CheckAvailabilityResponse;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.IsAvailable);
            Assert.AreEqual(1, response.Messages.Count);
            Assert.AreEqual("Username 'existingUser' is already taken", response.Messages[0]);
        }


    }
}

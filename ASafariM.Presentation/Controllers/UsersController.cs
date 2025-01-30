using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Services;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        // mapper
        private readonly IMapper _mapper;

        public UsersController(
            IUserService userService,
            ILogger<UsersController> logger,
            IMapper mapper
        )
        {
            _userService = userService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            _logger.LogInformation("Getting all users");
            try
            {
                var users = await _userService.GetAllUsersAsync();
                _logger.LogInformation($"Successfully retrieved {users.Count()} users");
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all users");
                return StatusCode(500, "An error occurred while retrieving users");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _userService.CreateUserAsync(command);
                return CreatedAtAction(nameof(GetAllUsers), null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating user");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("admin")]
        public async Task<IActionResult> CreateUserByAdmin(
            [FromBody] CreateUserByAdminCommand command
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _userService.CreateUserByAdminAsync(command);
                return CreatedAtAction(nameof(GetAllUsers), null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating user by admin");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(
            [FromRoute] Guid id,
            [FromBody] UpdateUserCommand command
        )
        {
            if (!ModelState.IsValid)
            {
                // Return 400 with the validation errors
                return BadRequest(ModelState);
            }

            // Ensure the ID in the route matches the command
            if (id != command.Id)
            {
                return BadRequest("ID mismatch between route and command");
            }

            var userUpdated = await _userService.UpdateUserAsync(command);
            if (userUpdated == null)
                return NotFound();

            return Ok(userUpdated);
        }

        [HttpPut("admin/{id}")]
        public async Task<IActionResult> UpdateUserByAdmin(
            [FromRoute] Guid id,
            [FromBody] UpdateUserByAdminCommand command
        )
        {
            if (id != command.Id)
                return BadRequest("ID mismatch between route and command");

            var userUpdated = await _userService.UpdateUserByAdminAsync(command);
            if (userUpdated == null)
                return NotFound();

            return Ok(userUpdated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(
            [FromRoute] Guid id,
            [FromBody] DeleteUserCommand command
        )
        {
            _logger.LogInformation("Attempting to delete user with ID: {UserId}", id);

            if (command == null || string.IsNullOrEmpty(command.Password))
            {
                return BadRequest(new { message = "Password is required" });
            }

            var isDeleted = await _userService.DeleteUserAsync(id, command.Password);
            if (!isDeleted)
            {
                _logger.LogWarning("User with ID {UserId} not found or deletion failed", id);
                return NotFound(new { message = "User delete failed" });
            }

            _logger.LogInformation("User with ID {UserId} deleted successfully", id);
            return NoContent();
        }

        [HttpDelete("admin/{id}")]
        public async Task<IActionResult> DeleteUserByAdmin(
            [FromRoute] Guid id,
            [FromBody] DeleteUserByAdminCommand command
        )
        {
            _logger.LogInformation("Attempting to delete user with ID: {UserId}", id);

            if (command == null || command.IsAdmin == false)
            {
                return Forbid("Access Denied: You do not have permission to delete this user.");
            }

            var isDeleted = await _userService.DeleteUserByAdminAsync(id, command.IsAdmin);
            if (!isDeleted)
            {
                _logger.LogWarning("User with ID {UserId} not found or deletion failed", id);
                return NotFound(new { message = "User delete failed" });
            }

            _logger.LogInformation("User with ID {UserId} deleted successfully", id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUserById([FromRoute] Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                _logger.LogWarning("User with ID {UserId} not found", id);
                return NotFound();
            }
            _logger.LogInformation("User with ID {UserId} found", id);

            return Ok(user);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<UserDto>>> SearchUsers(
            [FromQuery] string? username = null,
            [FromQuery] string? email = null
        )
        {
            var users = await _userService.SearchUsersAsync(username, email);
            return Ok(users);
        }

        //UserChangePasswordUpdate
        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordCommand command)
        {
            var isUpdated = await _userService.ChangePasswordAsync(command);
            if (!isUpdated)
            {
                return BadRequest("Password update failed");
            }

            return NoContent();
        }

        [HttpGet("check-availability/validate")]
        public async Task<ActionResult<object>> CheckAvailability(
            [FromQuery] string? username = null,
            [FromQuery] string? email = null
        )
        {
            _logger.LogInformation(
                "Checking availability for username: {Username}, email: {Email}",
                username,
                email
            );

            if (username == null && email == null)
            {
                return BadRequest(
                    new { message = "Either username or email parameter is required" }
                );
            }

            var result = new EmailUsernameAvailabilityDto
            {
                UsernameAvailability =
                    username != null ? await _userService.IsUsernameNotTakenAsync(username) : null,
                EmailAvailability =
                    email != null ? await _userService.IsEmailNotTakenAsync(email) : null,
            };

            _logger.LogInformation(
                "Availability result - Username: {UsernameAvailability}, Email: {EmailAvailability}",
                result.UsernameAvailability?.IsTaken,
                result.EmailAvailability?.IsTaken
            );

            // Check if either username or email is taken
            var messages = new List<string>();
            if (result.UsernameAvailability?.IsTaken == true)
            {
                messages.Add($"Username '{username}' is already taken");
            }
            if (result.EmailAvailability?.IsTaken == true)
            {
                messages.Add($"Email '{email}' is already registered");
            }

            var isAvailable = !messages.Any(); // Available only if no validation messages

            _logger.LogInformation("Final availability result: {IsAvailable}", isAvailable);

            return Ok(
                new CheckAvailabilityResponse { IsAvailable = !messages.Any(), Messages = messages }
            );
        }
    }
}

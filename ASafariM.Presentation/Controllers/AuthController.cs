using System.Security.Cryptography; // System.Security.Cryptography
using ASafariM.Application.CommandModels; // Command models
using ASafariM.Application.Services;
using ASafariM.Application.Utils;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserRepository? _userRepository;
    private readonly IUserService _userService;
    private readonly JwtTokenService _jwtTokenService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(
        IUserRepository userRepository,
        JwtTokenService jwtTokenService,
        IUserService userService,
        ILogger<AuthController> logger
    )
    {
        _userRepository = userRepository;
        _jwtTokenService = jwtTokenService;
        _userService = userService;
        _logger = logger;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] CreateUserCommand command)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            await _userService.CreateUserAsync(command);
            return Ok("User registered successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error during registration");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUserCommand command)
    {
        var user = await _userRepository.GetUserByEmailAsync(command.Email);
        if (user == null)
        {
            _logger.LogWarning("Invalid credentials for email: {Email}", command.Email);
            return new ObjectResult(new { message = "Invalid credentials" })
            {
                StatusCode = StatusCodes.Status401Unauthorized,
            };
        }

        // Check if account is locked
        if (user.IsLockedOut && user.LockoutEnd.HasValue && user.LockoutEnd.Value > DateTime.UtcNow)
        {
            var lockoutTimeRemaining = (user.LockoutEnd.Value - DateTime.UtcNow).Minutes;
            return new ObjectResult(
                new { message = $"Account is locked. Try again in {lockoutTimeRemaining} minutes." }
            )
            {
                StatusCode = StatusCodes.Status403Forbidden,
            };
        }

        if (!PasswordHasher.VerifyPassword(command.Password, user.PasswordHash))
        {
            _logger.LogWarning("Invalid credentials for user: {Email}", command.Email);

            // Increment failed login attempts
            user.FailedLoginAttempts++;

            // Lock the account if failed attempts reach 5
            if (user.FailedLoginAttempts >= 5)
            {
                user.IsLockedOut = true;
                user.LockoutEnd = DateTime.UtcNow.AddMinutes(15); // Lock account for 15 minutes
                _logger.LogWarning("User account locked out: {Email}", command.Email);
            }

            await _userRepository.UpdateUserAsync(user);

            return new ObjectResult(new { message = "Invalid credentials" })
            {
                StatusCode = StatusCodes.Status401Unauthorized,
            };
        }

        // Reset failed login attempts and update last login time
        user.FailedLoginAttempts = 0;
        user.IsLockedOut = false;
        user.LockoutEnd = null;
        user.LastLogin = DateTime.UtcNow;
        _logger.LogInformation(
            "Setting LastLogin for user {UserId} to {LastLogin}",
            user.Id,
            user.LastLogin
        );

        try
        {
            await _userRepository.UpdateUserAsync(user);
            _logger.LogInformation("Successfully updated LastLogin for user {UserId}", user.Id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to update LastLogin for user {UserId}", user.Id);
        }

        var token = _jwtTokenService.GenerateJwtToken(user);
        return Ok(
            new
            {
                Token = token,
                Authenticated = user.IsDeleted != true,
                AuthenticatedUser = user,
            }
        );
    }

    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        return Ok("Logout successful");
    }

    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword(ResetPasswordCommand command)
    {
        return Ok("Password reset successful");
    }

    [HttpPost("forgot-password")]
    public async Task<IActionResult> ForgotPassword(ForgotPasswordCommand command)
    {
        return Ok("Password reset link sent successfully");
    }

    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword(ChangePasswordCommand command)
    {
        await _userService.ChangePasswordAsync(command);
        return Ok("Password changed successfully");
    }

    [HttpPost("update-profile")]
    public async Task<IActionResult> UpdateProfile(UpdateProfileCommand command)
    {
        try
        {
            // Get current user ID from claims
            var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out Guid userId))
            {
                return Unauthorized("User not authenticated");
            }

            // Set the user ID in the command
            command.UserId = userId;

            await _userService.UpdateProfileAsync(command);
            return Ok("Profile updated successfully");
        }
        catch (InvalidOperationException ex)
        {
            _logger.LogError(ex, "Failed to update profile");
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating profile");
            return StatusCode(500, "Internal server error");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRepository? _userRepository;
        private readonly ILogger<UserRolesController> _logger;

        // mapper
        private readonly IMapper _mapper;

        public UserRolesController(
            IUserRepository userRepository,
            ILogger<UserRolesController> logger,
            IMapper mapper
        )
        {
            _userRepository = userRepository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost("{userId}/roles")]
        public async Task<IActionResult> AssignRolesToUser(
            string userId,
            [FromBody] IEnumerable<Guid> roleIds
        )
        {
            _logger.LogInformation(
                $"Assigning roles to user: {userId}, Roles: {string.Join(", ", roleIds)}"
            );

            if (!roleIds.Any())
            {
                return BadRequest("No roles provided for assignment.");
            }

            try
            {
                var parsedUserId = Guid.Parse(userId);
                if (!await _userRepository.UserExistsAsync(parsedUserId))
                {
                    return NotFound($"User with ID {userId} not found.");
                }

                await _userRepository.AssignRolesToUserAsync(parsedUserId, roleIds);
                return Ok();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (FormatException)
            {
                return BadRequest($"Invalid user ID format: {userId}");
            }
        }

        [HttpDelete("{userId}/roles")]
        public async Task<IActionResult> RemoveRolesFromUser(
            string userId,
            [FromBody] IEnumerable<Guid> roleIds
        )
        {
            if (!roleIds.Any())
            {
                return BadRequest("No roles provided for removal.");
            }

            try
            {
                var parsedUserId = Guid.Parse(userId);
                if (!await _userRepository.UserExistsAsync(parsedUserId))
                {
                    return NotFound($"User with ID {userId} not found.");
                }

                // Verify that user has all the roles to be removed
                var userRoles = await _userRepository.GetRolesByUserIdAsync(parsedUserId);
                var userRoleIds = userRoles.Select(ur => ur.RoleId);
                var nonExistentRoles = roleIds.Except(userRoleIds);

                if (nonExistentRoles.Any())
                {
                    return BadRequest(
                        $"User does not have the following roles: {string.Join(", ", nonExistentRoles)}"
                    );
                }

                await _userRepository.RemoveRolesFromUserAsync(parsedUserId, roleIds);
                return Ok();
            }
            catch (FormatException)
            {
                return BadRequest($"Invalid user ID format: {userId}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while removing roles: {ex.Message}");
            }
        }

        [HttpGet("{userId}/roles/{roleId}")]
        public async Task<IActionResult> UserHasRole(Guid userId, Guid roleId)
        {
            bool hasRole = await _userRepository.UserHasRoleAsync(userId, roleId);
            return Ok(hasRole);
        }

        [HttpGet("{userId}/roles")]
        public async Task<ActionResult<UserRoleDto[]>> GetRolesByUserIdAsync(string userId)
        {
            try
            {
                var parsedUserId = Guid.Parse(userId);
                if (!await _userRepository.UserExistsAsync(parsedUserId))
                {
                    return NotFound($"User with ID {userId} not found.");
                }

                var roles = await _userRepository.GetRolesByUserIdAsync(parsedUserId);
                return Ok(_mapper.Map<IEnumerable<UserRole>, IEnumerable<UserRoleDto>>(roles));
            }
            catch (FormatException)
            {
                return BadRequest($"Invalid user ID format: {userId}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving roles: {ex.Message}");
            }
        }
    }
}

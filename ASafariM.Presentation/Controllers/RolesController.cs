using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// This controller handles operations related to roles in the application.
    /// </summary>
    /// <remarks>
    /// This controller provides endpoints for managing roles in the application.
    /// </remarks>
    public class RolesController : Controller
    {
        private readonly RoleService? _roleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RolesController"/> class.
        /// </summary>
        /// <param name="roleService">The service used to manage roles.</param>
        public RolesController(RoleService roleService)
        {
            _roleService = roleService;
        }

        // Get roles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            if (_roleService == null)
            {
                return NotFound();
            }
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }

        // GET ROLE NAMES
        /// <summary>
        /// Gets the name of the role by its unique identifier.
        /// </summary>
        /// <param name="roleId">The unique identifier of the role.</param>
        /// <returns>The name of the role.</returns>
        [HttpGet("{roleId}")]
        public async Task<ActionResult<string>> GetRoleName(Guid roleId)
        {
            if (roleId == Guid.Empty)
            {
                return BadRequest("Role ID cannot be empty.");
            }
            if (_roleService == null)
            {
                return NotFound();
            }
            var role = await _roleService.GetRoleByIdAsync(roleId);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role.Name);
        }
    }
}

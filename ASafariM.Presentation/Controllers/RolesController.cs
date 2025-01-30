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
    public class RolesController : ControllerBase
    {
        private readonly RoleService _roleService;

        public RolesController(RoleService roleService)
        {
            _roleService = roleService;
        }

        // Get roles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }


        // GET ROLE NAMES
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetRoleName(Guid id)
        {
            var role = await _roleService.GetRoleByIdAsync(id);
            return Ok(role.Name);
        }
    }
}

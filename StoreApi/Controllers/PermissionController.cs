using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Model;
using StoreApi.Services;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    public class PermissionController : Controller
    {
        private readonly IPermission _permission;

        public PermissionController(IPermission permission)
        {
            _permission = permission;
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(Permission))]
        [HttpGet(ApiRoutes.Permission.GetPermissionId)]
        public async Task<IActionResult> GetPermission([FromRoute] int id)
        {
            var result = await _permission.getPermission(id);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Permission))]
        [HttpPost(ApiRoutes.Permission.AddPermissionId)]
        public async Task<IActionResult> AddPermission([FromBody] Permission user)
        {
            var result = await _permission.addPermission(user);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Permission))]
        [HttpPut(ApiRoutes.Permission.EditPermissionId)]
        public async Task<IActionResult> EditPermission([FromBody] Permission user)
        {
            var result = await _permission.editPermission(user);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Permission))]
        [HttpDelete(ApiRoutes.Permission.DeletePermissionId)]
        public async Task<IActionResult> DeletePermission([FromRoute] int id)
        {
            var result = await _permission.deletePermission(id);
            return Ok(result);
        }
    }
}

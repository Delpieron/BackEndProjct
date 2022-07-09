using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Services;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUser _user;

        public UsersController(IUser user)
        {
            _user = user;
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(User))]
        [HttpGet(ApiRoutes.User.GetUserId)]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            var result = await _user.getUser(id);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(User))]
        [HttpPost(ApiRoutes.User.AddUserId)]
        public async Task<IActionResult> AddExercise([FromBody] User user)
        {
            var result = await _user.addUser(user);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(User))]
        [HttpPut(ApiRoutes.User.EditUserId)]
        public async Task<IActionResult> EditUser([FromBody] User user)
        {
            var result = await _user.editUser(user);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(User))]
        [HttpDelete(ApiRoutes.User.DeleteUserId)]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var result = await _user.deleteUser(id);
            return Ok(result);
        }
    }
}

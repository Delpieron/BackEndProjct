using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StoreApi;
using StoreApi.Services;

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
        [HttpGet(ApiRoutes.User.GetUserId)]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            var result = await _user.getUser(id);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.User.AddUserId)]
        public async Task<IActionResult> AddExercise([FromBody] User user)
        {
            var result = await _user.addUser(user);
            return Ok(result);
        }
       [AllowAnonymous]
        [HttpPut(ApiRoutes.User.EditUserId)]
        public async Task<IActionResult> EditUser([FromBody] User user)
        {
            var result = await _user.editUser(user);
            return Ok(result);
        }
        [AllowAnonymous]
        [HttpDelete(ApiRoutes.User.DeleteUserId)]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var result = await _user.deleteUser(id);
            return Ok(result);
        }
    }
}

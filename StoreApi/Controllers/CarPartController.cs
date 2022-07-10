using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Models;
using StoreApi.Services;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    public class CarPartController : Controller
    {
        private readonly ICarPart _carPart;

        public CarPartController(ICarPart carPart)
        {
            _carPart = carPart;
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpGet(ApiRoutes.CarParts.GetCarPartsId)]
        public async Task<IActionResult> GetUser([FromRoute] int id)
        {
            var result = await _carPart.getCarPart(id);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpPost(ApiRoutes.CarParts.AddCarPartsId)]
        public async Task<IActionResult> AddExercise([FromBody] CarPart carPart)
        {
            var result = await _carPart.addCarPart(carPart);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpPut(ApiRoutes.CarParts.EditCarPartsId)]
        public async Task<IActionResult> EditUser([FromBody] CarPart carPart)
        {
            var result = await _carPart.editCarPart(carPart);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(CarPart))]
        [HttpDelete(ApiRoutes.CarParts.DeleteCarPartsId)]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var result = await _carPart.deleteCarPart(id);
            return Ok(result);
        }
    }
}

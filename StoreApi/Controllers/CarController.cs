﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Services;
using System.Threading.Tasks;

namespace StoreApi.Controllers
{
    public class CarController : Controller
    {
        private readonly ICar _car;

        public CarController(ICar car)
        {
            _car = car;
        }
        [AllowAnonymous]
        [ProducesDefaultResponseType(typeof(Car))]
        [HttpGet(ApiRoutes.Car.GetCarId)]
        public async Task<IActionResult> GetCar([FromRoute] int id)
        {
            var result = await _car.getCar(id);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(User))]
        [HttpPost(ApiRoutes.Car.AddCarId)]
        public async Task<IActionResult> AddCar([FromBody] Car car)
        {
            var result = await _car.addCar(car);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Car))]
        [HttpPut(ApiRoutes.Car.EditCarId)]
        public async Task<IActionResult> EditCar([FromBody] Car car)
        {
            var result = await _car.editCar(car);
            return Ok(result);
        }
        [ProducesDefaultResponseType(typeof(Car))]
        [HttpDelete(ApiRoutes.Car.DeleteCarId)]
        public async Task<IActionResult> DeleteCar([FromRoute] int id)
        {
            var result = await _car.deleteCar(id);
            return Ok(result);
        }
    }
}

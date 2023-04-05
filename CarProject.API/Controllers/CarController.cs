using CarProject.Domain.Entities;
using CarProject.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace CarProject.API.Controllers
{
    [Authorize]
    [RoutePrefix("api/car")]
    public class CarController : ApiController
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpPost]
        [Route("CreateCar")]
        [SwaggerOperation("CreateCar")]
        [SwaggerResponse(HttpStatusCode.OK, "Car created", typeof(Car))]
        public IHttpActionResult CreateCar(Car car)
        {
            var createdCar = _carService.AddCarAsync(car);
            return Ok(createdCar);
        }

        [HttpPatch]
        [Route("{id:int}")]
        [SwaggerOperation("UpdateCar")]
        [SwaggerResponse(HttpStatusCode.OK, "Car updated", typeof(Car))]
        public IHttpActionResult UpdateCar(int id, [FromBody] Car carPatch)
        {
            var updatedCar = _carService.UpdateCarAsync(id, carPatch);
            return Ok(updatedCar);
        }

        [HttpGet]
        [Route("GetCarsByYear")]
        [SwaggerOperation("GetCarsByYear")]
        [SwaggerResponse(HttpStatusCode.OK, "List of cars", typeof(List<Car>))]
        public IHttpActionResult GetCarsByYear(int year)
        {
            var cars = _carService.GetCarsByYearAsync(year);
            return Ok(cars);
        }


        [HttpGet]
        [Route("GetAllCars")]
        [SwaggerOperation("GetAllCars")]
        [SwaggerResponse(HttpStatusCode.OK, "List of all cars", typeof(List<Car>))]
        public IHttpActionResult GetAllCars()
        {
            var cars = _carService.GetAllCarsAsync();
            return Ok(cars);
        }

    }
}

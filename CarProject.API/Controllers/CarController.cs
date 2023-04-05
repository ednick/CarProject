﻿using CarProject.Domain.Entities;
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
    [RoutePrefix("api/car")]
    public class CarController : ApiController
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("CreateCar")]
        [SwaggerOperation("CreateCar")]
        [SwaggerResponse(HttpStatusCode.OK, "Car created", typeof(Car))]
        public IHttpActionResult CreateCar(Car car)
        {
            var createdCar = _carService.AddCarAsync(car);
            return Ok(createdCar);
        }
    }
}
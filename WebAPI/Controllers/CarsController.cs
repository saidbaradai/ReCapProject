using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var cars = _carService.GetAll();

            if (cars.IsSuccess)
            {
                return Ok(cars.Data);
            }
            return BadRequest(cars.Message);
        }


        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var cars = _carService.Add(car);
            if (cars.IsSuccess)
            {
                return Ok(cars.Message);
            }
            return BadRequest(cars.Message);
        }


    }
}

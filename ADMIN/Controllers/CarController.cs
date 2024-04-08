using AutoMapper;
using CarManagement.Model;
using CarManagement.Service.CarService;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ADMIN.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICarServices CarServices;

        public CarController(IMapper mapper,ICarServices carService)
        {
            _mapper = mapper;
            CarServices = carService;
        }
        // Cho phép toàn bộ hệ thống có thể xem xe
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetAllCars()
        {
            var cars = await CarServices.GetAllCarsAsync();
            return Ok(cars);
        }
        // Cho phép toàn bộ hệ thống tìm xe theo id
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCarById(int id)
        {
            var car = await CarServices.GetCarByIdAsync(id);
            if (car == null)
            {
                return NotFound(); // Trả về 404 Not Found nếu không tìm thấy xe
            }
            return Ok(car); 
        }
        
        [HttpPut("createcar")]
        public async Task<ActionResult> CreateCar([FromQuery]CarDTO carDto)
        {
            // Ánh xạ dữ liệu từ DTO sang đối tượng Car
            var car = new Car
            {
                // Ánh xạ các trường từ DTO sang Car
                 car_model = carDto.car_model,
                car_description = carDto.car_description,
                car_type = carDto.car_type,
                car_status = carDto.car_status,
                car_price = carDto.car_price,
                car_sell_date = carDto.car_sell_date,
            };

            // Thêm đối tượng Car vào cơ sở dữ liệu
            var createdCar = await CarServices.CreateCarAsync(car);
            return Ok(createdCar);
        }
        
        [HttpPut("update-price")]
        public async Task<IActionResult> UpdateCarPrice(UpdateCarPriceDTO updateCarPriceDTO)
        {
            try
            {
                await CarServices.UpdateCarPriceAsync(updateCarPriceDTO);
                return Ok("Car price updated successfully");
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while updating car price");
            }
        }

      
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar(int id, Car car)
        {
            var updatedCar = await CarServices.UpdateCarAsync(id, car);
            if (updatedCar == null)
            {
                return NotFound();
            }
            return Ok(updatedCar);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var result = await CarServices.DeleteCarAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

using CarManagement.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Service.CarService
{
    public interface ICarServices
    {
        Task<IEnumerable<Car>> GetAllCarsAsync();
        Task<Car> GetCarByIdAsync(int id);
        Task<Car> CreateCarAsync(Car car);
        Task<Car> UpdateCarAsync(int id, Car car);
        Task<bool> DeleteCarAsync(int id);
        Task<CarDTO> UpdateCarPriceAsync(UpdateCarPriceDTO updateCarPriceDTO);
    }
}

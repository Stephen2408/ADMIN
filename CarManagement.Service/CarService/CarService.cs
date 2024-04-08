using CarManagement.Model;
using CarManagement.Repository.Data;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Service.CarService
{
    public class CarService : ICarServices
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task UpdateCarPriceAsync(UpdateCarPriceDTO updateCarPriceDTO)
        {
            var carToUpdate = await _context.Cars.FindAsync(updateCarPriceDTO.CarId);
            if (carToUpdate != null)
            {
                carToUpdate.car_price = updateCarPriceDTO.NewPrice;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException("Car not found");
            }
        }

        public async Task<Car> CreateCarAsync(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return car;
        }

        public async Task<bool> DeleteCarAsync(int id)
        {
            var carToDelete = await _context.Cars.FindAsync(id);
            if (carToDelete != null)
            {
                _context.Cars.Remove(carToDelete);
                await _context.SaveChangesAsync();
                return true; // Trả về true nếu xe đã được xóa thành công
            }
            else
            {
                throw new ArgumentException("Car not found");
            }
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async  Task<Car> GetCarByIdAsync(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task<Car> UpdateCarAsync(int id, Car car)
        {
            if (id != car.car_id)
            {
                throw new ArgumentException("Car ID mismatch");
            }

            _context.Entry(car).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return car;
        }

        Task<CarDTO> ICarServices.UpdateCarPriceAsync(UpdateCarPriceDTO updateCarPriceDTO)
        {
            throw new NotImplementedException();
        }
    }
}

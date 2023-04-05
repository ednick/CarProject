using CarProject.Domain;
using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _cars;

        public CarRepository()
        {
            _cars = new List<Car>();
        }

        public  Task InsertCarAsync(Car car)
        {
            using (var s = new CarContext())
            {
                s.Cars.Add(car);
                s.SaveChanges();
            }

            return Task.CompletedTask;
        }

        public async Task UpdateCarAsync(Car car)
        {
            using (var s = new CarContext())
            {
                var existingCar = s.Cars.FirstOrDefault(c => c.Id == car.Id);
                if (existingCar != null)
                {
                    existingCar.Name = car.Name;
                    existingCar.Color = car.Color;
                    existingCar.YearMade = car.YearMade;
                    await s.SaveChangesAsync();
                }
            }
            
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            using (var s = new CarContext())
            {
                var carList =  s.Cars.ToList();

                return carList;
            }
             
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            using (var s = new CarContext())
            {
                var result = await s.Cars.FirstOrDefaultAsync(c => c.Id == id);

                return result;
            }
        }
    }

}

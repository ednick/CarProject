using CarProject.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Repository
{
    public interface ICarRepository
    {
        /// <summary>
        /// Get All Cars
        /// </summary>
        /// <returns></returns>
        Task<List<Car>> GetAllCarsAsync();
        
        /// <summary>
        /// Get Cars By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Car> GetCarByIdAsync(int id);
        
        /// <summary>
        /// Insert/ Create new Car
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        Task InsertCarAsync(Car car);

        /// <summary>
        /// Update Car Information
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        Task UpdateCarAsync(Car car);
    }
}
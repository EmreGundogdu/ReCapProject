using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice= 1500,Description = "Range Rover Velar",ModelYear = 2020},
                new Car{Id = 2,BrandId = 1,ColorId = 2,DailyPrice= 900,Description = "BMW 5.20",ModelYear = 2019},
                new Car{Id = 3,BrandId = 2,ColorId = 3,DailyPrice= 2000,Description = "Audi A7 Rs",ModelYear = 2018},
                new Car{Id = 4,BrandId = 2,ColorId = 2,DailyPrice= 3500,Description = "Mercedes AMG S63",ModelYear = 2020},
                new Car{Id = 5,BrandId = 3,ColorId = 5,DailyPrice= 200,Description = "Fiat Doblo",ModelYear = 2013},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = null;
            carDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carDelete);
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carUpdate = null;
            carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}

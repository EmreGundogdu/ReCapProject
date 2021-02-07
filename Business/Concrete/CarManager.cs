using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;


        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;

        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public Car Get(int id)
        {
            return _cardal.Get(c => c.Id == id);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _cardal.Add(car);
            }
            else
            {
                throw new Exception("Günlük fiyatı 0 olamaz");
            }

        }

        public void Update(Car car)
        {
            _cardal.Update(car);
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cardal.GetAll(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _cardal.GetAll(c => c.ColorId == colorId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _cardal.GetCarDetails();
        }
    }
}

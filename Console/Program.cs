using System;
using System.Security.Cryptography.X509Certificates;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            //CarAdd();
            //BrandAdd();
            CarDetailList();
            //Operations();

            Console.ReadLine();
        }

        public static void Operations()
        {
            Console.WriteLine("**************************");
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car
            { Id = 4, BrandId = 3, ColorId = 2, DailyPrice = 5000, Description = "Audi", ModelYear = 2008 });
            CarDetailList();
            Console.WriteLine("**************************");
            carManager.Update(new Car
            { Id = 4, BrandId = 5, ColorId = 3, ModelYear = 2013, DailyPrice = 2000, Description = "kiralandı" });
            CarDetailList();
            Console.WriteLine("**************************");
            carManager.Add(new Car { BrandId = 3, ColorId = 2, DailyPrice = 2300, Description = " ", ModelYear = 2011 });
            CarDetailList();
        }

        public static void CarDetailList()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Id + " : " + car.CarName + " / " + car.Color + " / " + car.DailyPrice + " / " +
                                  car.ModelYear + " / " + car.Description);
            }
        }

        public static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car();
            car1.BrandId = 3;
            car1.ColorId = 4;
            car1.DailyPrice = 0;
            car1.Description = "Audi A6";

            try
            {
                carManager.Add(car1);
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }

            Console.WriteLine("**********************");
        }

        public static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand();
            brand1.Name = "A";
            try
            {
                brandManager.Add(brand1);
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }

            Console.WriteLine("*****************************");
        }
    }
}

using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager.getAll())
            {
                Console.WriteLine("Marka  = " + cars.Description +" ||  "+ " Günlük Fiyatı = "+ cars.DailyPrice);
            }
        }
    }    
}

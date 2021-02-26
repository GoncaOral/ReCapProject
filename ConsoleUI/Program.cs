using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            }

            Console.WriteLine(".....................................................................");
            carManager.Add(new Car
            {
                Id = 4,
                CarName = "GNC01",
                BrandId = 1,
                ColorId = 4,
                ModealYear = 2021,
                DailyPrice = 8000,
                Description = "Jet Hızında"
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            }

            Console.WriteLine(".....................................................................");

            carManager.Delete(new Car { Id = 2 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            }

            Console.WriteLine(".....................................................................");

            carManager.Update(new Car
            {
                Id = 4,
                CarName = "GNC01",
                BrandId = 1,
                ColorId = 4,
                ModealYear = 2021,
                DailyPrice = 10000,
                Description = "Jet Hızında"
            });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            }
        }
    }
}

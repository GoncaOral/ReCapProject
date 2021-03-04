using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }

            Console.WriteLine(".....................................................................");

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            //}

            //Console.WriteLine(".....................................................................");

            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            //}

            //Console.WriteLine(".....................................................................");

            //foreach (var car in carManager.GetCarsByColorId(4))
            //{
            //    Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            //}

            //Console.WriteLine(".....................................................................");

            //carManager.Add(new Car
            //{
            //    Id = 4,
            //    CarName = "GNC01",
            //    BrandId = 1,
            //    ColorId = 4,
            //    ModealYear = 2021,
            //    DailyPrice = 8000,
            //    Description = "Jet Hızında"
            //});

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            //}

            //Console.WriteLine(".....................................................................");

            //carManager.Delete(new Car { Id = 2 });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            //}

            //Console.WriteLine(".....................................................................");

            //carManager.Update(new Car
            //{
            //    Id = 4,
            //    CarName = "GNC01",
            //    BrandId = 1,
            //    ColorId = 4,
            //    ModealYear = 2021,
            //    DailyPrice = 10000,
            //    Description = "Jet Hızında"
            //});

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.CarName + " " + car.DailyPrice + " " + car.Description);
            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { 
            //BrandId=1,
            //BrandName="BMW"            
            //});
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            //}
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { 
            //ColorId=4,
            //ColorName="Black"
            //});

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorId + " " + color.ColorName);
            //}
        }
    }
}

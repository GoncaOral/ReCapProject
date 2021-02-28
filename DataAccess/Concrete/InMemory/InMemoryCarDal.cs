using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id=1,CarName="BM100",BrandId=1,ColorId=1,ModealYear=2021,DailyPrice=3000,Description="Yeni Model"},
            new Car{Id=2,CarName="W200",BrandId=2,ColorId=2,ModealYear=2020,DailyPrice=2000,Description="Klasik Model"},
            new Car{Id=3,CarName="CATG50",BrandId=2,ColorId=3,ModealYear=2019,DailyPrice=4000,Description="Eski Model"},
            new Car{Id=4,CarName="CAT60",BrandId=2,ColorId=3,ModealYear=2019,DailyPrice=4000,Description="Eski Model"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {
           return _cars.Where(c=>c.Id == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModealYear = car.ModealYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

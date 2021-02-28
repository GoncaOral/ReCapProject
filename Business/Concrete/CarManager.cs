using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length < 2 && car.DailyPrice < 0)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter ve günlük fiyatı 0'dan büyük olmalıdır. ");
            }
            else
            {
                _CarDal.Add(car);
            }
           
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetById(int CarId)
        {
            return _CarDal.GetById(CarId);
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _CarDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _CarDal.GetAll(c=>c.ColorId==Id);
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}

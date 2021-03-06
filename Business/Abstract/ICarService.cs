using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICarService
  {
        IDataResult<List<Car>> GetById(int CarId);
        IDataResult<List<Car>> GetCarsByBrandId(int Id);
        IDataResult<List<Car>> GetCarsByColorId(int Id);
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}

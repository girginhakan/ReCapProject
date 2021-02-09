using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetById(int id);
        List<Car> GetAll();
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByModelYear(int year);
        List<CarRentDetailDto> GetCarDetails();
    }
}

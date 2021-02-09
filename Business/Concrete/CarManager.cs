using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.CarName.Length >= 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Tebrikler Araba başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Araba ismi 2 harften daha büyük ve günlük kullanım bedeli 0 dan büyük olmalıdır.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba silme işleminiz gerçekleşmiştir.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p => p.CarId == id);
        }

        public List<Car> GetByModelYear(int year)
        {
            return _carDal.GetAll(p => p.ModelYear==year);
        }

        public List<CarRentDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            if (car.DailyPrice>0 && car.CarName.Length>=2)
            {
                _carDal.Update(car);
                Console.WriteLine("Araba profili güncellenmiştir.");
            }
        }

    }
}

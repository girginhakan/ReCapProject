using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice>0 && car.CarName.Length < 2)
            {

                return new ErrorResult("Araba ismi min 2 karakterden oluşmalıdır.");
                
            }
                _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

           
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Araba silme işleminiz gerçekleşmiştir.");
        }

        public IDataResult <List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccesDataResult<List<Car>> (_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccesDataResult<Car>(_carDal.Get(p => p.CarId == id));
        }

        public IDataResult<List<Car>> GetByModelYear(int year)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(p => p.ModelYear==year));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccesDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice<0 && car.CarName.Length<2)
            {
                return new ErrorResult("Lütfen arabanın günlük fiyatı 0 'dan büyük ve araba ismini min 2 karakter olacak şekilde tekrar deneyiniz.");
            }
                _carDal.Update(car);
            return new SuccessResult("Araba profili güncellenmiştir.");
               
        }

    }
}

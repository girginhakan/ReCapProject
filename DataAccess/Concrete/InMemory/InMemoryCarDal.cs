using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,CarName="Nissan Micra",ModelYear=2000,DailyPrice=75,Description="Çok konforlu olmasada iki kişi çok az yakan ucuz bir arabadır."},
                new Car{CarId=2,BrandId=2,ColorId=2,CarName="Renault Clio",ModelYear=2011,DailyPrice=100,Description="Ucuz, az yakan ve aile için kullanışlı arabadır. "},
                new Car{CarId=3,BrandId=3,ColorId=3,CarName="Opel Corsa",ModelYear=2015,DailyPrice=125,Description="Küçük ancak konforlu bir arabadır. Yakıt tüketimi ortalamadır."},
                new Car{CarId=4,BrandId=4,ColorId=4,CarName="BMW",ModelYear=2017,DailyPrice=200,Description="Konforlu ve lüks bir arabadır. Yakıt tüketimi ortalamanın üzerindedir."},
                new Car{CarId=5,BrandId=5,ColorId=5,CarName="Mercedes",ModelYear=2020,DailyPrice=300,Description="Son teknoloji lüks bir arabadır."}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarName = car.CarName;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

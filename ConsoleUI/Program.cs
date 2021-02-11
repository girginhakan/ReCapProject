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
            


            Car carAdd = new Car { CarName = "Toyota",BrandId=1,ColorId=2,DailyPrice=300,ModelYear=2021,Descriptions="çok güzeldir."};
            carManager.Add(carAdd);
            Console.WriteLine(carAdd.CarName +"/" +carAdd.Descriptions);

            

           


            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }
    }
}

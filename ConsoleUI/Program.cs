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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());



            //CarAddedTest(carManager);
            //CarDetailTest(carManager);

            User userAdd = new User
            {
                FirstName = "Hakan",
                LastName = "Girgin",
                Email = "hakangirgin7@gmail.com",
                Password = "12345"
            };
            userManager.Add(userAdd);
            userManager.GelAll();
        }




        private static void CarDetailTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success == true)
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

        private static void CarAddedTest(CarManager carManager)
        {
            Car carAdd = new Car { CarName = "Toyota", BrandId = 1, ColorId = 2, DailyPrice = 300, ModelYear = 2021, Descriptions = "çok güzeldir." };
            carManager.Add(carAdd);
            Console.WriteLine(carAdd.CarName + "/" + carAdd.Descriptions);
        }
    }
}

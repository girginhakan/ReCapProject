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


            // CarAddedTest(carManager);
            //CarDetailTest(carManager);
            //UserAddTest(userManager);
        }

        private static void UserAddTest(UserManager userManager)
        {
            User userAdd = new User
            {
                FirstName = "Hakan",
                LastName = "Girgin",
                Email = "hakangirgin7@gmail.com",
                Password = "12345"
            };
            userManager.Add(userAdd);
            var result = userManager.GelAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.LastName);
            }
        }

        private static void CarAddedTest(CarManager carManager)
        {
            Car carAdd = new Car { CarName = "Toyota", BrandId = 1, ColorId = 2, DailyPrice = 300, ModelYear = 2021, Descriptions = "çok güzeldir." };
            carManager.Add(carAdd);
            Console.WriteLine(carAdd.CarName + "/" + carAdd.Descriptions);
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

    }
}

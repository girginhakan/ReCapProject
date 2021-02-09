using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>=2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Markanız başarıyla eklenmiştir.");
            }
            else
            {
                Console.WriteLine("Marka ismi 2 harften büyük olmalıdır. Lütfen tekrar deneyiniz.");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka sistemden silinmiştir.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(p => p.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka sistemde basariyla guncellendi.");
            }
            else
            {
                Console.WriteLine("Lutfen marka ismini en az iki karakter olacak sekilde tekrar deneyiniz.");
            }
        }
    }
}

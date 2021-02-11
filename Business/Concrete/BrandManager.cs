using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
               return new ErrorResult("Marka ismi 2 harften büyük olmalıdır. Lütfen tekrar deneyiniz.");
            }
                _brandDal.Add(brand);
                return new SuccessResult("Markanız başarıyla eklenmiştir.");
            
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult ("Marka sistemden silinmiştir.");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccesDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccesDataResult<Brand>(_brandDal.Get(p => p.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length < 2)
            {
               return new ErrorResult("Lutfen marka ismini en az iki karakter olacak sekilde tekrar deneyiniz.");
            }
                _brandDal.Update(brand);
            return new SuccessResult("Marka sistemde basariyla guncellendi.");

        }
    }
}

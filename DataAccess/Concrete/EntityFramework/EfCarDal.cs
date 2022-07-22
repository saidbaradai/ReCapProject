using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RetCarContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (RetCarContext db=new RetCarContext())
            {
                 var result = from car in db.Cars
                             join brand in db.Brands
                             on car.BrandId equals brand.Id
                             join color in db.Colors
                             on car.ColorId equals color.Id
                             select new CarDetailsDto
                             { 
                                 Id=car.Id, BrandName=brand.Name, ModelYear=car.ModelYear, ColorName=color.Name
                             };
                return result.ToList();
            }
            
        }





    }
}

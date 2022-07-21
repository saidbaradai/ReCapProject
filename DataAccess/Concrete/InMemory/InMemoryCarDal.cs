using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars=new List<Car>()
        {
            new Car(){Id=1,BrandId=1,ColorId=1,DailyPrice=1000,ModelYear=1913,Description="Cok guzel"},
            new Car(){Id=2,BrandId=2,ColorId=1,DailyPrice=4543,ModelYear=1964,Description="Cok iyi"},
            new Car(){Id=3,BrandId=1,ColorId=1,DailyPrice=2234,ModelYear=1565,Description="harika"},
            new Car(){Id=4,BrandId=2,ColorId=1,DailyPrice=7567,ModelYear=1989,Description="fena degil"},
        };

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.Id == car.Id));
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public Car GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).SingleOrDefault();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}

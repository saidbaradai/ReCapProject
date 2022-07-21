using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService 
    {
        public Car GetById(int carId);
        Car GetCarsByBrandId(int brandId);
        public List<Car> GetAll();
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);
    }
}

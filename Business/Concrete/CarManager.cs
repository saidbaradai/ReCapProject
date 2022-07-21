using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _icarDal;
        public CarManager(ICarDal carDal)
        {
            _icarDal = carDal;
        }

        public void Add(Car car)
        {
            _icarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _icarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _icarDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _icarDal.GetById(carId);
        }

        public void Update(Car car)
        {
            _icarDal.Update(car);
        }
    }
}

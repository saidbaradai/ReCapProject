using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _icarDal.Add(car);
            return new SuccessResult(Messages.AddSuccessfuly);
        }

        public IResult Delete(Car car)
        {
            _icarDal.Delete(car);
            return new SuccessResult(Messages.DeltedSuccessfuly);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_icarDal.GetAll())  ;
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>( _icarDal.Get(c=>c.Id== carId));
        }

        public IDataResult<Car> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<Car>(_icarDal.Get(c => c.BrandId == brandId));
        }

        public IDataResult< List<CarDetailsDto>> GetCarsDtails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_icarDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _icarDal.Update(car);
            return new SuccessResult(Messages.UpdatedSuccessfuly);
        }
    }
}

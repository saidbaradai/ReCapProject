﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color==null)
            {
                return new ErrorResult("There is no color");
            }
            _colorDal.Add(color);
            return new SuccessResult("Color has been added successfuly");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll(c=>c.Name.StartsWith("B"));
        }

        public IDataResult<Color> GetById(int id)
        {
            if (id < 0)
            {
                return new ErrorDataResult<Color>();
            }
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult("Updated successfuly");
        }
    }
}

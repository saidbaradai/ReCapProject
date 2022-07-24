using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        Color GetById(int id);
        List<Color> GetAll();

    }
}

using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        T Get(Expression<Func<T,bool> > filtre);
        List<T> GetAll(Expression<Func<T,bool>> filtre =null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

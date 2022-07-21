using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var entityToAdd = db.Entry(entity);
                entityToAdd.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var entityToDelete = db.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                db.SaveChanges();
            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filtre)
        {
            using (TContext db = new TContext())
            {
                return db.Set<TEntity>()
                    .First(filtre);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filtre = null)
        {
            using (TContext db = new TContext())
            {
                return filtre == null ? db.Set<TEntity>().ToList() : db.Set<TEntity>().Where(filtre).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var entityToModifie = db.Entry(entity);
                entityToModifie.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

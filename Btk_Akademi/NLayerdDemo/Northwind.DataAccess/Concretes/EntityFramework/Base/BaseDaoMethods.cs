using Northwind.DataAccess.Abstracts.Base;
using Northwind.Entites.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concretes.EntityFramework.Base
{
    public class BaseDaoMethods<TEntity, TContext> : IBaseRepositorySignature<TEntity>
        where TEntity : class, IGroupEntity, new()
        where TContext : DbContext, new()

    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext()) 
            {
                return
                (filter != null)
                ? context.Set<TEntity>().Where(filter).ToList()
                : context.Set<TEntity>().ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }

        }

        public void Add(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var AddedEntity =  context.Entry(Entity);
                AddedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var UpdatedEntity = context.Entry(Entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity Entity)
        {
            using (TContext context = new TContext())
            {
                var DeletedEntity = context.Entry(Entity);
                DeletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

   
    }
}

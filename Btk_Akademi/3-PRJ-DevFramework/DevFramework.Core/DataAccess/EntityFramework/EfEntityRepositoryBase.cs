using DevFramework.Core.Entities;
using System.Data.Entity;
using System.Linq.Expressions;


namespace DevFramework.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? filter)
        {
            using (var context = new TContext())
            {
                return filter == null
                       ? context.Set<TEntity>().ToList()
                       : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                TEntity nullEntity = new TEntity();
                var  filterItem  = context.Set<TEntity>().SingleOrDefault(filter);

                if (filterItem != null)
                    return filterItem;
                else
                    return nullEntity;

            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                return entity;
            }
        }
        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                return entity;

            }
        }
        public bool Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;

                return (deletedEntity == null);
            }
        }

    }
}

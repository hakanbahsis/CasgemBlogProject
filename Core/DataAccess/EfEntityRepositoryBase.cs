using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class, new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);//entityleri eşleştiriyorum
                addedEntity.State = EntityState.Added;//ekleme işlemi olduğunu belirtiyorum
                context.SaveChanges();//kaydediyorum
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);//entityleri eşleştiriyorum
                addedEntity.State = EntityState.Deleted;//silme işlemi olduğunu belirtiyorum
                context.SaveChanges();//kaydediyorum
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);//entityleri eşleştiriyorum
                addedEntity.State = EntityState.Modified;//güncelleme işlemi olduğunu belirtiyorum
                context.SaveChanges();//kaydediyorum
            }
        }
    }
}

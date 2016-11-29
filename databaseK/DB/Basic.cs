using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using databaseK.Context;
using System.Data.Entity;

namespace databaseK.DB
{
    public class Basic<TEntity> where TEntity : class
    {

        protected DbSet<TEntity> context;

        public Basic(MyContext context)
        {
            this.context = context.Set<TEntity>();
        }

        public TEntity add(TEntity entity)
        {
            return context.Add(entity);
        }

        public void add_range(IEnumerable<TEntity> entities)
        {
            context.AddRange(entities);
        }

        public TEntity get(long id)
        {
            return context.Find(id);
        }

        public IEnumerable<TEntity> get_all()
        {
            return context.ToList();
        }

        public TEntity remove(TEntity entity)
        {
            return context.Remove(entity);
        }

        public void remove_range(IEnumerable<TEntity> entities)
        {
            context.RemoveRange(entities);
        }

        public long count()
        {
            return context.Count();
        }

        public TEntity first(Expression<Func<TEntity, bool>> predicate)
        {
            return context.First(predicate);
        }

        public IEnumerable<TEntity> where(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Where(predicate);
        }

        public TEntity last()
        {
            return context.Last();
        }

        public TEntity lastOrDefault()
        {
            return context.LastOrDefault();
        }
    }
}

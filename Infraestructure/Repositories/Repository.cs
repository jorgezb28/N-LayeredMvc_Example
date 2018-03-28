using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Generic;

namespace Infraestructure.Repositories
{
    public class Repository<T>:IRepository<T> where T:class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public T GetSingle(Expression<Func<T, bool>> filter)
        {
            return Context.Set<T>().FirstOrDefault(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Attach(entity);
            Context.Set<T>().Remove(entity);
        }
    }
}

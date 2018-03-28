using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generic
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        T GetSingle(Expression<Func<T,bool>> filter);
        IEnumerable<T> GetAll();
        void Remove(T entity);
    }
}

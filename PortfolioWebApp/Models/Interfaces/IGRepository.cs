using System;
using System.Linq;
using System.Linq.Expressions;

namespace PortfolioWebApp.Models.Interfaces
{
   public interface IGRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> Include(params Expression<Func<T, object>>[] includes);
    }
}

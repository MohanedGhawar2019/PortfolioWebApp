using Microsoft.EntityFrameworkCore;
using PortfolioWebApp.Models.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PortfolioWebApp.Models.Repositories
{
    public class GRepository<T> : IGRepository<T> where T : class
    {
        private readonly DataContext _context;
        private DbSet<T> table = null;
        public GRepository(DataContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = GetById(id);
            table.Remove(existing);
        }

       
        public IQueryable<T> GetAll()
        {
            return table;
        }

        public T GetById(object id)
        {
            return table.Find(id); 
        }       

        public void Insert(T entity)
        {
            table.Add(entity);
        }
        public void Update(T entity)
        {
            table.Update(entity);
            //table.Attach(entity);          
            //_context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Include(params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

    }
}

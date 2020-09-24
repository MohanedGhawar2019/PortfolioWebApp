using PortfolioWebApp.Models.Interfaces;
using PortfolioWebApp.Models.Repositories;

namespace PortfolioWebApp.Models.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext _context;
        private IGRepository<T> _entity;
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public IGRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GRepository<T>(_context));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}

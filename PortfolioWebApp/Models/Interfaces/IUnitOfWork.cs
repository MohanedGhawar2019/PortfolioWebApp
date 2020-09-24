using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWebApp.Models.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        IGRepository<T> Entity { get; }
        void Save();
    }
}

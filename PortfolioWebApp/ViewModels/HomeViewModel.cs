using PortfolioWebApp.Models.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioWebApp.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public List<Photos> photos { get; set; }
    }
}

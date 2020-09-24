using Microsoft.AspNetCore.Mvc;
using PortfolioWebApp.Models.Enteties;
using PortfolioWebApp.Models.Interfaces;
using PortfolioWebApp.ViewModels;
using System.Linq;

namespace PortfolioWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Photos> _photos;
        private readonly IUnitOfWork<Owner> _owner;

        public HomeController(
            IUnitOfWork<Photos> photos,
            IUnitOfWork<Owner> owner)
        {
            _photos = photos;
            _owner = owner;
        }
       
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Owner = _owner.Entity.GetAll().First(),
                photos = _photos.Entity.GetAll().ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
       
    }
}

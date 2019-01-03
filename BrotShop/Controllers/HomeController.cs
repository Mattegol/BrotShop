using BrotShop.Models;
using BrotShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BrotShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGoodieRepository _goodieRepository;

        public HomeController(IGoodieRepository goodieRepository)
        {
            _goodieRepository = goodieRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Title = "Brots goodies",
                Goodies = _goodieRepository.GetAllGoodies().OrderBy(g => g.Name).ToList()
            };

            return View(viewModel);
        }
    }
}
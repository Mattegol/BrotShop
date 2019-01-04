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
            return View();
        }

        public IActionResult Goodies()
        {
            var viewModel = new HomeViewModel
            {
                Title = "Brot's goodies",
                Goodies = _goodieRepository.GetAllGoodies().OrderBy(g => g.Name).ToList()
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var goodie = _goodieRepository.GetGoodieById(id);

            if (goodie == null) return NotFound();

            return View(goodie);

        }

    }
}
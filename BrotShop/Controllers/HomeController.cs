using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrotShop.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View(_goodieRepository.GetAllGoodies());
        }
    }
}
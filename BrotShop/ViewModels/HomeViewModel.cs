using BrotShop.Models;
using System.Collections.Generic;

namespace BrotShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }

        public List<Goodie> Goodies { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrotShop.Models
{
    public interface IGoodieRepository
    {
        IEnumerable<Goodie> GetAllGoodies();

        Goodie GetGoodieById(int goodieId);
    }
}

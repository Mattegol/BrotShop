using System.Collections.Generic;

namespace BrotShop.Models
{
    public interface IGoodieRepository
    {
        IEnumerable<Goodie> GetAllGoodies();

        Goodie GetGoodieById(int goodieId);
    }
}

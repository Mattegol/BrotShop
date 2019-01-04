using System.Collections.Generic;
using System.Linq;

namespace BrotShop.Models
{
    public class GoodieRepository : IGoodieRepository
    {
        private readonly ApplicationDbContext _context;

        public GoodieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Goodie> GetAllGoodies()
        {
            return _context.Goodies;
        }

        public Goodie GetGoodieById(int goodieId)
        {
            return _context.Goodies.FirstOrDefault(g => g.Id == goodieId);
        }
    }
}

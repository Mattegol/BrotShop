using Microsoft.EntityFrameworkCore;

namespace BrotShop.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Goodie> Goodies { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }


    }
}

using BookTracker.Model;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
        }
        public DbSet<Book> Book { get; set; }
    }
}

using App2.Models;
using Microsoft.EntityFrameworkCore;

namespace App2.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}

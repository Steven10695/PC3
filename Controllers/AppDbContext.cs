using Microsoft.EntityFrameworkCore;
using PC3.Models;

namespace PC3.Controllers
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public AppDbContext(DbContextOptions p) : base (p)
        {
            
        }
        
    }
}
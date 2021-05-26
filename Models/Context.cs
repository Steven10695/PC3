using Microsoft.EntityFrameworkCore;

namespace PC3.Models
{
    public class Context : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Busco> Buscos { get; set; }

    }
}
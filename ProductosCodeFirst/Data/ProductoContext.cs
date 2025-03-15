using Microsoft.EntityFrameworkCore;
using ProductosCodeFirst.Models;

namespace ProductosCodeFirst.Data
{
    public class ProductoContext:DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext>options)
            : base(options) { }

        public DbSet<Producto> Productos { get; set; }

        
    }
}

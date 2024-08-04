using Microsoft.EntityFrameworkCore;
using ProyectoLibrary.Domain.Entities;

namespace ProyectoFinal.Infraestructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autore> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}

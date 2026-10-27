using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using TiendaOnlineEmanuel.API.Models;


namespace TiendaOnlineEmanuel.API.Data
{
    public class TiendaOnlineDbContext : DbContext
    {
        public TiendaOnlineDbContext(DbContextOptions<TiendaOnlineDbContext> options)
        : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}

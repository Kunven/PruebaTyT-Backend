using Microsoft.EntityFrameworkCore;
namespace PruebaTyT_Backend.Models
{
    public class PruebaContext : DbContext
    {
        public PruebaContext(DbContextOptions<PruebaContext> options)
       : base(options)
        {
        }

        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Cargos> Cargos { get; set; } = null!;
        public DbSet<Departamentos> Departamentos { get; set; } = null!;
    }
}

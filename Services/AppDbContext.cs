using Microsoft.EntityFrameworkCore;
using ProyectoIntegradoVMS.Models;

namespace PI_Vicente.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

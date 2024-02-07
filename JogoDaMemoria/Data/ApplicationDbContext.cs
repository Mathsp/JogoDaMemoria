using JogoDaMemoria.Models;
using Microsoft.EntityFrameworkCore;

namespace JogoDaMemoria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}

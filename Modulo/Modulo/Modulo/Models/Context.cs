using Microsoft.EntityFrameworkCore;

namespace Modulo.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> Options) : base(Options)
        {

        }
        public DbSet<Reservas> Reserva { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Fala> Falas { get; set; }
    }
}

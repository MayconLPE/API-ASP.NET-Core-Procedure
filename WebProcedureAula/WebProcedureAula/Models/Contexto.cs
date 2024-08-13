using Microsoft.EntityFrameworkCore;

namespace WebProcedureAula.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Produto> Produto { get; set; }
    }
}

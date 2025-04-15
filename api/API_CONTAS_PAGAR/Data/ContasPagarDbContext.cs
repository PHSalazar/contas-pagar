using API_CONTAS_PAGAR.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CONTAS_PAGAR.Data
{
    public class ContasPagarDbContext : DbContext
    {
        public ContasPagarDbContext(DbContextOptions<ContasPagarDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ContaModel>()
                .HasKey(c => c.IdConta);
        }
        public DbSet<ContaModel> Contas { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}

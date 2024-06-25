using Lanchonete.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.Infraestrutura.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Domain;
using Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<CategoriaProduto> CategoriasProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configurações 
            // configurações para entidade de relacionamento
           

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}

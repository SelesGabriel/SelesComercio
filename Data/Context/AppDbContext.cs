using Microsoft.EntityFrameworkCore;
using SelesMiudeza.Data.Map;
using SelesMiudeza.Model;

namespace SelesMiudeza.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PessoaMap());
            builder.ApplyConfiguration(new CategoriaMap());
            builder.ApplyConfiguration(new ProdutoMap());
        }
    }
}

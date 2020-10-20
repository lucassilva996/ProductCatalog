using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
using ProductCatalog.Data.Maps;

namespace ProductCatalog.Data
{
    // Herança da classe DBContext, é feita com o simbolo de : (dois pontos)
    public class StoreDataContext : DbContext
    {
        //mapeamento de produtos e categorias
            public DbSet<Product> Products {get; set;}
            public DbSet<Category> Categories {get; set;}

            //sobrescrita do método OnConfiguring, herdado de DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection String
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-04NO5JF; Database=prodcat; User ID=SA; password=ld201013");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
        }
    }
}
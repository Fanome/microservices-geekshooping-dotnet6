using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            modelBuilder.Entity<Product>().HasData( new Product
            {
                id = 2,
                Name = "Camisa do Mario",
                Price = new decimal(70.9),
                Description = "Description Camisa do Mario",    
                ImageURL = "https://static3.tcdn.com.br/img/img_prod/577735/camiseta_mario_infantil_18954327_1_20210716154503.jpg",
                CategoryName = "Camisa"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                id = 3,
                Name = "Camisa do Luigi",
                Price = new decimal(50.9),
                Description = "Description Camisa do Luigi",
                ImageURL = "https://images.tcdn.com.br/img/img_prod/579685/camiseta_luigi_358_1_20180215104006.jpg",
                CategoryName = "Camisa"
            });
        }
    }
}
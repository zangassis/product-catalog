    using Microsoft.EntityFrameworkCore;
    using ProductCatalog.Models;

    namespace ProductCatalog.Data;
    public class ProductCatalogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
           options.UseSqlite("DataSource = productCatalog; Cache=Shared");

        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
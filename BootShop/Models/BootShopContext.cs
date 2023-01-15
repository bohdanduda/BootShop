using Microsoft.EntityFrameworkCore;

namespace BootShop.Models
{
    public class BootShopContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<AdminData> AdminDatas { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4c1_dudabohdan_db1;user=dudabohdan;password=123456;SslMode=none");
        }
    }
}
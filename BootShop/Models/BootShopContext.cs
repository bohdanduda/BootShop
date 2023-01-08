using Microsoft.EntityFrameworkCore;

namespace BootShop.Models
{
    public class BootShopContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4c1_dudabohdan_db1;user=dudabohdan;password=123456;SslMode=none");
        }
    }
}
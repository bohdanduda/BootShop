using Microsoft.EntityFrameworkCore;

namespace BootShop.Models
{
    public class BootShopContext : DbContext
    {
        public DbSet<Size> Size { get; set; }
        public DbSet<Color> Color { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4c1_dudabohdan_db1;user=dudabohdan;password=123456;SslMode=none");
        }

    }

}

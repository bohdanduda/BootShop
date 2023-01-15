using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("admin")]
    public class AdminUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; }
        
        [Column("password")]
        public string Password{ get; set; }
    }
}

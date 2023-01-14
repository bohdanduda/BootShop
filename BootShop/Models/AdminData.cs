using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("admin_data")]
    public class AdminData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("admin_username")]
        public string Username { get; set; }
        
        [Column("admin_password")]
        public string Password{ get; set; }
    }
}

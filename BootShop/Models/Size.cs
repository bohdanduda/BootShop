using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("size")]
    public class Size
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
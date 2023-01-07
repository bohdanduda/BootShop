using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("subcategory")]
    public class Subcategory
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
    }
}

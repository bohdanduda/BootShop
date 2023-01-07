using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("category")]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}

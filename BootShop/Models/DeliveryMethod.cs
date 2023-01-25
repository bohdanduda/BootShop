using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{

    [Table("delivery_method")]
    public class DeliveryMethod
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("price")]
        public string Price { get; set; }
    }

}

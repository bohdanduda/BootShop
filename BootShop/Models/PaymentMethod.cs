using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{

    [Table("payment_method")]
    public class PaymentMethod
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}

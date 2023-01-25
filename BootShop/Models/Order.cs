
using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("order")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        
        [Column("total_price")]
        public double TotalPrice { get; set; }
        
        [Column("customer_id")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public virtual Customer Customer{ get; set; }

        [Column("delivery_method_id")]
        [ForeignKey("DeliveryMethod")]
        public int DeliveryMethodId { get; set; }

        public virtual DeliveryMethod DeliveryMethod { get; set; }

        [Column("payment_method_id")]
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        [Column("note")]
        public string? Note { get; set; }
    }
}


using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("order_item")]
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("product_variant_id")]
        [ForeignKey("ProductVariant")]
        public int ProductVariantId { get; set; }

        public virtual ProductVariant ProductVariant { get; set; }

        [Column("order_id")]
        [ForeignKey("Order")]
        public int OrderId{ get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("unit_price")]
        public double UnitPrice { get; set; }

        [Column("total_price")]
        public double TotalPrice { get; set; }
    }
}

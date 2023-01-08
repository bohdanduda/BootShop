using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("product_variant")]
    public class ProductVariant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //PK, v db nastaveno jako auto_increment (automaticky vyplňuje databázi)
        [Column("id")]
        public int Id { get; set; }

        [Column("product_id")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Column("color_id")]
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }

        [Column("size_id")]
        [ForeignKey("Size")]
        public int SizeId { get; set; }

        [Column("remaining_stock")]
        public int RemainingStock { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("price_discount")]
        public double PriceDiscount { get; set; }

    }
}

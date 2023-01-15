using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("product_photo")]
    public class ProductPhoto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //PK, v db nastaveno jako auto_increment (automaticky vyplňuje databázi)
        [Column("id")]
        public int Id { get; set; }

        [Column("product_id")]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Column("filename")]
        public string Filename { get; set; }
       
    }
}

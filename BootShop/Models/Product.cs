using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("product")]
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //PK, v db nastaveno jako auto_increment (automaticky vyplňuje databázi)
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("brand_id")]
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }

        [Column("category_id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Column("subcategory_id")]
        [ForeignKey("Subcategory")]
        public int? SubcategoryId { get; set; }
        public virtual Subcategory? Subcategory { get; set; }

        [Column("summary")]
        public string Summary { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("code")]
        public string Code { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("material")]
        public string Material { get; set; }

        [Column("purpose")]
        public string Purpose { get; set; }
    }
}

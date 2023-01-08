using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{

    [Table("brand")]
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("logo_filename")]
        public string LogoFilename { get; set; }
    }

}

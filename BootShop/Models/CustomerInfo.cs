using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("customer")]
    public class CustomerInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("id")]
        public int Id { get; set; }
        [Column("customer_name")]
        public string Name { get; set; }
        [Column("customer_surname")]
        public string Surname { get; set; }
        [Column("customer_town")]
        public string Town { get; set; }
        [Column("customer_street")]
        public string Street{ get; set; }
        [Column("customer_house_number")]
        public int HouseNumber { get; set; }
        [Column("customer_zipcode")]
        public int Zipcode { get; set; }
        [Column("customer_phone")]
        public int Phone { get; set; }
        [Column("customer_email")]
        public string Email { get; set; }
    }
}

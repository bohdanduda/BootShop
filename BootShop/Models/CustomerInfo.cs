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
        [Column("customer_address")]
        public string Address { get; set; }
        [Column("customer_town")]
        public string Town { get; set; }
        [Column("customer_zipcode")]
        public string Zipcode { get; set; }
        [Column("customer_phone")]
        public string Phone { get; set; }
        [Column("customer_email")]
        public string Email { get; set; }

        public CustomerInfo(string name, string surname, string address, string town, string zipcode, string phone, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.Town = town;
            this.Zipcode = zipcode;
            this.Phone = phone;
            this.Email = email;
        }
    }
}

﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BootShop.Models
{
    [Table("color")]
    public class Color
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("hex_code")]
        public string HexCode { get; set; }
    }
}


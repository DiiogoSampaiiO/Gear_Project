﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gear_Desktop.Models
{
    public class Deposito_00
    {
        [Key]
        public int Dep_code { get; set; }

        [Required]
        [StringLength(50)]
        public string Dep_name { get; set; }
    }
}

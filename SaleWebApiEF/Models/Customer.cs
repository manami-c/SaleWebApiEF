using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace SaleWebApiEF.Models
{
    public class Customer
    {       
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string Code { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; } = DateTime.Now;

        public Customer()
        {

        }
    }
}

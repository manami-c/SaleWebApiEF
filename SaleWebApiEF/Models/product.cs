using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebApiEF.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price{ get; set; }

        public Product() { }
    }
}

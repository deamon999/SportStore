using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DBService.Models
{
    public class Product
    {
        public long Id { get; set; }
        [Required]
        [StringLength(12)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal RetailPrice { get; set; }

        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DBService.Models
{
    public class Order
    {
        public long Id { get; set; }
        [Required]
        [StringLength(12)]
        public string CustomerName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
        public bool Shipped { get; set; }

        public IEnumerable<OrderLine> Lines { get; set; }
    }
}

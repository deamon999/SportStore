using System;
using System.Collections.Generic;
using System.Text;

namespace DBService.Models
{
    public class OrderLine
    {
        public long Id { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }
    }
}

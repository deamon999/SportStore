using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBService.Models
{
    public class Category
    {
        public long Id { get; set; }
        [Required]
        [StringLength(12)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
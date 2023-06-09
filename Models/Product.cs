using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusExamples.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public int AfterDiscountPrice { get; set; }
        public Company Company { get; set; }
    }
}

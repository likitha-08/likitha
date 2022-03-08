using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceCaseStudy2.Models
{
    public partial class ProductTable
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductSize { get; set; }
        public string ProductColor { get; set; }
        public string ProductDescription { get; set; }
        public string Category { get; set; }
        public int? Mrp { get; set; }
        public int? Discount { get; set; }
        public int? FinalPrice { get; set; }
    }
}

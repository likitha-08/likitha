using System;
using System.Collections.Generic;

#nullable disable

namespace CaseStudy2.Models
{
    public partial class Tb2Size
    {
        public int Id { get; set; }
        public string SizeName { get; set; }
        public int? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

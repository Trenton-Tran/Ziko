using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class ProductPrice
    {
        public decimal ProductId { get; set; }
        public int BranchId { get; set; }
        public int? Price { get; set; }
        public int? OldPrice { get; set; }
        public decimal? ImportPrice { get; set; }
        public decimal? OldImportPrice { get; set; }
    }
}

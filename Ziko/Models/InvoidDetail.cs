using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class InvoidDetail
    {
        public decimal RowId { get; set; }
        public decimal InvoidId { get; set; }
        public decimal ProductId { get; set; }
        public decimal? Amount { get; set; }
        public int Price { get; set; }
        public int ImportPrice { get; set; }
        public int Discount { get; set; }
    }
}

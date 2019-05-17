using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class ImportInvoidDetail
    {
        public decimal RowId { get; set; }
        public decimal InvoidId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal Cost { get; set; }
    }
}

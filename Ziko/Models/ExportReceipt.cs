using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class ExportReceipt
    {
        public decimal ExportId { get; set; }
        public decimal ReceiptId { get; set; }
        public int? Money { get; set; }
    }
}

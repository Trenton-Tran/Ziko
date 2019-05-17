using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class InvoidReceipt
    {
        public decimal InvoidId { get; set; }
        public decimal ReceiptId { get; set; }
        public int? Money { get; set; }
    }
}

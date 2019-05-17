using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class ImportPayment
    {
        public decimal ImportId { get; set; }
        public decimal PaymentId { get; set; }
        public int? Money { get; set; }
    }
}

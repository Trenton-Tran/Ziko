using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Customer
    {
        public decimal CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerAdd { get; set; }
        public DateTime? Birdthday { get; set; }
        public int BranchId { get; set; }
        public int Debt { get; set; }
        public int Kind { get; set; }
        public int Discount { get; set; }
        public int Offline { get; set; }
    }
}

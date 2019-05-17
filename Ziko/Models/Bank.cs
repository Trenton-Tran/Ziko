using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Bank
    {
        public int BankId { get; set; }
        public string AccNumber { get; set; }
        public string OwnerName { get; set; }
        public string BankName { get; set; }
        public int? BranchId { get; set; }
    }
}

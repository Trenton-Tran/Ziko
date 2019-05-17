using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Payments
    {
        public decimal PaymentId { get; set; }
        public string PaymentCode { get; set; }
        public DateTime PaymentDate { get; set; }
        public int BranchId { get; set; }
        public decimal CustomerId { get; set; }
        public int BankId { get; set; }
        public string Explain { get; set; }
        public int Money { get; set; }
        public string PayForm { get; set; }
        public int CatId { get; set; }
        public int AccountDebt { get; set; }
        public int ProfitAccounting { get; set; }
        public DateTime DateCreate { get; set; }
        public string AccCreate { get; set; }
    }
}

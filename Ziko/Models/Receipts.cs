using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Receipts
    {
        public decimal ReceiptId { get; set; }
        public string ReceiptCode { get; set; }
        public DateTime ReceiptDate { get; set; }
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

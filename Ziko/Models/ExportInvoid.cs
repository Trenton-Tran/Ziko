using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class ExportInvoid
    {
        public decimal InvoidId { get; set; }
        public string InvoidCode { get; set; }
        public DateTime InvoidDate { get; set; }
        public decimal CustomerId { get; set; }
        public int BranchId { get; set; }
        public int SumMoney { get; set; }
        public int SumDiscount { get; set; }
        public int SumPay { get; set; }
        public int SumRootPrice { get; set; }
        public int Kind { get; set; }
        public DateTime DateCreate { get; set; }
        public string AccCreate { get; set; }
    }
}

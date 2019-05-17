using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Invoid
    {
        public decimal InvoidId { get; set; }
        public string InvoidCode { get; set; }
        public DateTime InvoidDate { get; set; }
        public int SumMoney { get; set; }
        public int SumDiscount { get; set; }
        public int SumPay { get; set; }
        public int SumRootPrice { get; set; }
        public int TableId { get; set; }
        public decimal CustomerId { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateEnd { get; set; }
        public string AccCreate { get; set; }
        public int State { get; set; }
    }
}

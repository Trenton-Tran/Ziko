using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class PaymentCategory
    {
        public int CatId { get; set; }
        public string Code { get; set; }
        public string Explain { get; set; }
        public string Kind { get; set; }
        public int CorpId { get; set; }
        public int AccountDebt { get; set; }
        public int ProfitAccounting { get; set; }
    }
}

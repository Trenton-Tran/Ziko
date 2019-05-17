using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Product
    {
        public decimal ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductBarcode { get; set; }
        public string Unit { get; set; }
        public int? GroupId { get; set; }
        public int? Kind { get; set; }
        public int? CorpId { get; set; }
        public string Img { get; set; }
        public int? Offline { get; set; }
    }
}

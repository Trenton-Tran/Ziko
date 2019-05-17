using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class ProductGroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Img { get; set; }
        public int? ParentId { get; set; }
        public int? CorpId { get; set; }
        public int? Kind { get; set; }
    }
}

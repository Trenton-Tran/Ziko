using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchAdd { get; set; }
        public string BranchPhone { get; set; }
        public int? CorpId { get; set; }
    }
}

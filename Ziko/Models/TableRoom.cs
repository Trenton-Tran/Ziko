using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class TableRoom
    {
        public int TableId { get; set; }
        public string TableName { get; set; }
        public int? State { get; set; }
        public int? BranchId { get; set; }
        public int? TableGroupId { get; set; }
        public int? Offline { get; set; }
        public int? PricePerHour { get; set; }
    }
}

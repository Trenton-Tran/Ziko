using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class TableRoomGroup
    {
        public int TableGroupId { get; set; }
        public string TableGroupName { get; set; }
        public int BranchId { get; set; }
    }
}

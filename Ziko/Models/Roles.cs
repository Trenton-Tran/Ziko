using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Roles
    {
        public int AccId { get; set; }
        public string PrincipleCode { get; set; }
        public int BranchId { get; set; }
        public int AllowAdd { get; set; }
        public int AllowEdit { get; set; }
        public int AllowDel { get; set; }
        public int AllowView { get; set; }
        public int AllowEditAnotherAcc { get; set; }
    }
}

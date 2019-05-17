using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string AccName { get; set; }
        public int? BranchId { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int AccLevel { get; set; }
        public string TokenString { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Ziko.Models
{
    public partial class Districts
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public int? ProvinceId { get; set; }
    }
}

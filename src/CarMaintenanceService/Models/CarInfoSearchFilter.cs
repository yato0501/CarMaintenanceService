using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMaintenanceService.Models
{
    public class CarInfoSearchFilter
    {
        public string Field { get; set; }
        public string Operation { get; set; }
        public string Value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMaintenanceService.Models
{
    public class CarInfoSearch
    {
        public List<CarInfoSearchFilter> filters { get; set; }
    }
}

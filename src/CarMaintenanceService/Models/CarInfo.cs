using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMaintenanceService.Models
{
    public class CarInfo
    {
        public string CarNickName { get; set; }
        public string Vin { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public List<MaintenanceItem> History { get; set; } 
    }
}

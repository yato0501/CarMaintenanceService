using System;
using System.Collections.Generic;

namespace CarMaintenanceService.Models
{
    public class MaintenanceItem
    {
        DateTime CreatedDate { get; set; }
        string Description { get; set; }
        List<string> Images { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMaintenanceService.Models
{
    public class CarInfoResponse
    {
        public CarInfoResponse()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public CarInfoResponse(CarInfoRequest carInfoRequest)
        {
            this.Id = Guid.NewGuid().ToString();
            this.CarNickName = carInfoRequest.CarNickName;
            this.Vin = carInfoRequest.Vin;
            this.Make = carInfoRequest.Make;
            this.Year = carInfoRequest.Year;
            this.History = carInfoRequest.History;
        }

        public string Id { get; set; }
        public string CarNickName { get; set; }
        public string Vin { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public List<MaintenanceItem> History { get; set; } 
    }
}

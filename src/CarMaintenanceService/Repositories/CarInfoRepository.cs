using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarMaintenanceService.Models;

namespace CarMaintenanceService.Repositories
{
    public class CarInfoRepository : ICarInfoRepository
    {
        public CarInfo PersistCarInfo(CarInfo carInfo)
        {
            return carInfo;
        }
    }
}

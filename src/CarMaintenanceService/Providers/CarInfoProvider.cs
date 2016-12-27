using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarMaintenanceService.Models;
using CarMaintenanceService.Repositories;

namespace CarMaintenanceService.Providers
{
    public class CarInfoProvider : ICarInfoProvider
    {
        ICarInfoRepository _repo;
        CarInfoProvider(ICarInfoRepository repo)
        {
            _repo = repo;
        }


        public CarInfo PersistCarInfo(CarInfo carInfo)
        {
            return _repo.PersistCarInfo(carInfo);
        }
    }
}

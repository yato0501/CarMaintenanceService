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
        public CarInfoProvider(ICarInfoRepository repo)
        {
            _repo = repo;
        }


        public async Task<CarInfoResponse> PersistCarInfo(CarInfoRequest carInfo)
        {
            return await _repo.PersistCarInfo(carInfo);
        }
    }
}

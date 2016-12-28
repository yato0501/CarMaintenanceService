using CarMaintenanceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMaintenanceService.Repositories
{
    public interface ICarInfoRepository
    {
        Task<CarInfoResponse> PersistCarInfo(CarInfoRequest carInfo);
    }
}

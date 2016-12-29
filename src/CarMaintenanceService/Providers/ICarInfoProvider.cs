using CarMaintenanceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarMaintenanceService.Providers
{
    public interface ICarInfoProvider
    {
        Task<CarInfoResponse> PersistCarInfo(CarInfoRequest carInfo);
        Task<IEnumerable<CarInfoResponse>> GetCarInfoList(CarInfoSearch carInfoSearch);
        Task<CarInfoResponse> GetCarInfo(string guid);
    }
}

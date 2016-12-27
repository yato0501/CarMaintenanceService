﻿using CarMaintenanceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarMaintenanceService.Providers
{
    public interface ICarInfoProvider
    {
        CarInfo PersistCarInfo(CarInfo carInfo);
    }
}
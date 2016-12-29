using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarMaintenanceService.Models;
using CarMaintenanceService.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CarMaintenanceService.Providers
{
    public class CarInfoProvider : ICarInfoProvider
    {
        ICarInfoRepository _repo;
        public CarInfoProvider(ICarInfoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<CarInfoResponse>> GetCarInfoList(CarInfoSearch carInfoSearch)
        {
            var filter = buildFilter(carInfoSearch);
            IEnumerable<CarInfoResponse> carInfoList = await _repo.GetCarInfoList(filter);
            return carInfoList;
        }

        private FilterDefinition<CarInfoResponse> buildFilter(CarInfoSearch carInfoSearch)
        {
            var builder = Builders<CarInfoResponse>.Filter;
            FilterDefinition<CarInfoResponse> buildFilter = null;
            foreach (var filter in carInfoSearch.filters)
            {
                //we'll only support "equal" for now.
                if (filter.Operation.ToLower() == "equal")
                {
                    if (buildFilter == null)
                    {
                        buildFilter = builder.Eq(filter.Field, filter.Value);
                    }
                    else
                    {
                        buildFilter &= builder.Eq(filter.Field, filter.Value);
                    }
                }
            }

            return buildFilter;
        }

        public async Task<CarInfoResponse> PersistCarInfo(CarInfoRequest carInfo)
        {
            return await _repo.PersistCarInfo(carInfo);
        }

        public async Task<CarInfoResponse> GetCarInfo(string guid)
        {
            var builder = Builders<CarInfoResponse>.Filter;
            FilterDefinition<CarInfoResponse> buildFilter = builder.Eq("Id", guid);

            var carInfoList = await _repo.GetCarInfoList(buildFilter);

            //we should only have one since we're searching for id
            return carInfoList.FirstOrDefault();
        }
    }
}

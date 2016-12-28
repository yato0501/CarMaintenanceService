using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarMaintenanceService.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CarMaintenanceService.Repositories
{
    public class CarInfoRepository : ICarInfoRepository
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public CarInfoRepository()
        {
            string connectionString = "mongodb://administrator:abc123@ds054289.mlab.com:54289/car-info-dev";

            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            _client = new MongoClient(settings);
            _database = _client.GetDatabase("car-info-dev");
            
        }

        public async Task<CarInfoResponse> PersistCarInfo(CarInfoRequest carInfo)
        {

            CarInfoResponse response = new CarInfoResponse(carInfo);

            var collection = _database.GetCollection<CarInfoResponse>("carInfo");
            await collection.InsertOneAsync(response);

            return response;
        }
    }
}

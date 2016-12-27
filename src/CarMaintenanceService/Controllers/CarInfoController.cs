using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarMaintenanceService.Models;

namespace CarMaintenanceService.Controllers
{
    [Route("api/[controller]")]
    public class CarInfoController : Controller
    {
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public CarInfo Get(int id)
        {
            return new CarInfo();
        }

        // POST api/values
        [HttpPost]
        public CarInfo Post([FromBody]CarInfo carInfo)
        {
            return carInfo;
        }

        // PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

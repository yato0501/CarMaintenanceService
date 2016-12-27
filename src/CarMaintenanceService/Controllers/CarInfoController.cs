using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarMaintenanceService.Models;
using CarMaintenanceService.Providers;

namespace CarMaintenanceService.Controllers
{
    [Route("api/[controller]")]
    public class CarInfoController : Controller
    {
        ICarInfoProvider _provider;
        CarInfoController(/*ICarInfoProvider provider*/)
        {
            //_provider = provider;
        }
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/carinfo/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "works";
            //return Json(new CarInfo());
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]CarInfo carInfo)
        {
            //return Json(_provider.PersistCarInfo(carInfo));
            return Ok();
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

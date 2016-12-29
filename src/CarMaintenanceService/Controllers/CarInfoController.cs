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
        public CarInfoController(ICarInfoProvider provider)
        {
            _provider = provider;
        }

       [HttpPost("search")]
        public async Task<IActionResult> SearchCarInfo([FromBody]CarInfoSearch carInfoSearch)
        {
            return Ok(await _provider.GetCarInfoList(carInfoSearch));
        }
        
        [HttpGet("{guid}")]
        public async Task<IActionResult> GetCarInfo([FromRoute]string guid)
        {
            return Ok(await _provider.GetCarInfo(guid));
        }
        
        [HttpPost]
        public async Task<IActionResult> InsertCarInfo([FromBody]CarInfoRequest carInfo)
        {
            return Ok(await _provider.PersistCarInfo(carInfo));
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantOH.Application.Interface;
using RestaurantOH.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantAppService _restaurantAppService;
        public RestaurantController(IRestaurantAppService restaurantAppService)
        {
            _restaurantAppService = restaurantAppService;
        }

        [HttpPost("csvFile")]
        public async Task<ActionResult> InputCsvFile(IEnumerable<IFormFile> csvFile)
        {
            //falta dividir controller/appService/service

            long size = csvFile.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in csvFile)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { size, filePath });
        }

        [HttpGet("hour")]
        public IEnumerable<RestaurantViewModel> GetRestaurantsByHour(IEnumerable<RestaurantViewModel> restaurantsViewModel, TimeSpan hour)
        {
            return _restaurantAppService.GetRestaurantsByHour(restaurantsViewModel, hour);
        }

    }
}

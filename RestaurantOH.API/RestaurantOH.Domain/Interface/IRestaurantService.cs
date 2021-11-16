using Microsoft.AspNetCore.Http;
using RestaurantOH.Domain.Model;
using System;
using System.Collections.Generic;

namespace RestaurantOH.Domain.Interface
{
    public interface IRestaurantService : IBaseService<Restaurant>
    {
        IEnumerable<Restaurant> InputCsvFile(IEnumerable<IFormFile> csvFile);
        IEnumerable<Restaurant> GetRestaurantsByHour(IEnumerable<Restaurant> restaurants, TimeSpan hour);
    }
}

using Microsoft.AspNetCore.Http;
using RestaurantOH.Domain.Interface;
using RestaurantOH.Domain.Model;
using System;
using System.Collections.Generic;

namespace RestaurantOH.Domain.Service
{
    public class RestaurantService : BaseService<Restaurant>, IRestaurantService
    {
        public IEnumerable<Restaurant> GetRestaurantsByHour(IEnumerable<Restaurant> restaurants, TimeSpan hour)
        {
            //falta implementar
            return restaurants;
        }

        public IEnumerable<Restaurant> InputCsvFile(IEnumerable<IFormFile> csvFile)
        {
            //falta implementar
            throw new NotImplementedException();
        }
    }
}

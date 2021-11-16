using Microsoft.AspNetCore.Http;
using RestaurantOH.Application.ViewModel;
using System;
using System.Collections.Generic;

namespace RestaurantOH.Application.Interface
{
    public interface IRestaurantAppService : IBaseAppService<RestaurantViewModel>
    {
        IEnumerable<RestaurantViewModel> InputCsvFile(IEnumerable<IFormFile> csvFile);
        IEnumerable<RestaurantViewModel> GetRestaurantsByHour(IEnumerable<RestaurantViewModel> restaurantsViewModel, TimeSpan hour);
    }
}

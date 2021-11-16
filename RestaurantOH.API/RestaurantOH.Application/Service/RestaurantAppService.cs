using AutoMapper;
using Microsoft.AspNetCore.Http;
using RestaurantOH.Application.Interface;
using RestaurantOH.Application.ViewModel;
using RestaurantOH.Domain.Interface;
using RestaurantOH.Domain.Model;
using System;
using System.Collections.Generic;

namespace RestaurantOH.Application.Service
{
    public class RestaurantAppService : BaseAppService<RestaurantViewModel, Restaurant>, IRestaurantAppService
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IMapper _mapper;

        public RestaurantAppService(IRestaurantService restaurantService, IMapper mapper) 
            : base(restaurantService, mapper)
        {
            _restaurantService = restaurantService;
            _mapper = mapper;
        }

        public IEnumerable<RestaurantViewModel> GetRestaurantsByHour(IEnumerable<RestaurantViewModel> restaurantsViewModel, TimeSpan hour)
        {
            return _mapper.Map<IEnumerable<RestaurantViewModel>>(_restaurantService.GetRestaurantsByHour(_mapper.Map<IEnumerable<Restaurant>>(restaurantsViewModel), hour));
        }

        public IEnumerable<RestaurantViewModel> InputCsvFile(IEnumerable<IFormFile> csvFile)
        {
            return _mapper.Map<IEnumerable<RestaurantViewModel>>(_restaurantService.InputCsvFile(_mapper.Map<IEnumerable<IFormFile>>(csvFile)));
        }
    }
}

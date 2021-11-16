using AutoMapper;
using RestaurantOH.Application.ViewModel;
using RestaurantOH.Domain.Model;

namespace RestaurantOH.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Restaurant, RestaurantViewModel>();
        }
    }
}

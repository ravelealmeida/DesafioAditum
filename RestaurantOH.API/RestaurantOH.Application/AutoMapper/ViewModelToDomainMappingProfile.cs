using AutoMapper;
using RestaurantOH.Application.ViewModel;
using RestaurantOH.Domain.Model;

namespace RestaurantOH.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RestaurantViewModel, Restaurant>();
        }
    }
}

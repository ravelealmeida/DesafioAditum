using FluentAssertions.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RestaurantOH.Application.Interface;
using RestaurantOH.Application.Service;
using RestaurantOH.Domain.Interface;
using RestaurantOH.Domain.Service;

namespace RestaurantOH.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASPNET                        
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Services
            services.AddScoped<IRestaurantService, RestaurantService>();

            //Application
            services.AddScoped<IRestaurantAppService, RestaurantAppService>();
        }
    }
}

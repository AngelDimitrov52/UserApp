using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace src.Core.Application.Helpers.Configurations
{
    public static class ServicesConfigurationApplication
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserService, UserService>();

            return services;
        }
    }
}

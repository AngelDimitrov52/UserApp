using System.Reflection;
using FluentValidation;
using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace src.Core.Application.Helpers.Configurations
{
    public static class ServicesConfigurationApplication
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddSingleton<IUserService, UserService>();
            
            // services.AddValidatorsFromAssemblyContaining<UserCreateDtoValidator>();
            // services.AddValidatorsFromAssemblyContaining(typeof(UserCreateDtoValidator));
            services.AddValidatorsFromAssembly(assembly);
        
            services.AddAutoMapper(assembly);

            return services;
        }
    }
}

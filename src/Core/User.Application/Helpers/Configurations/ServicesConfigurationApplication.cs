using System.Reflection;
using FluentValidation.AspNetCore;
using src.Core.Application.Models.UserModels.Interfaces;
using src.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using src.Core.Application.Helpers.Validators;

namespace src.Core.Application.Helpers.Configurations
{
    public static class ServicesConfigurationApplication
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Get the current assembly where this code is located
            // This is useful for registering services, repositories, and other components
            // that are defined in the same assembly
            // It allows you to use reflection to find types and register them
            // without having to specify the assembly name explicitly
            // This is particularly useful in modular applications
            // where you want to keep the configuration code in a separate assembly
            var assembly = Assembly.GetExecutingAssembly();
            
            // Register AutoMapper with the current assembly
            // This will automatically scan for profiles in the assembly
            // and make them available for dependency injection
            // This is useful for mapping between DTOs and domain models
            // and other mapping scenarios
            // It allows you to define mapping configurations in a central place
            // and use them throughout your application
            // It also allows you to use AutoMapper's features like projection, flattening, etc
            // without having to manually configure them every time
            services.AddAutoMapper(assembly);
            
            // Register FluentValidation with the current assembly
            // This will automatically register all validators in the assembly
            // and make them available for dependency injection
            // This is useful for validating user input, DTOs, and other models
            // It allows you to define validation rules in a central place
            // and use them throughout your application
            // It also allows you to use FluentValidation's features like custom rules, conditions, etc
            // without having to manually configure them every time
             services.AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(assembly));
        

            // Register the IUserService implementation
            services.AddScoped<IUserService, UserService>();
            
            // Return the modified service collection
            return services;
        }
    }
}

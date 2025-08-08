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

using src.Core.Application.Models.UserModels.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using src.Infrastructure.Persistence.Repositories;

namespace src.Infrastructure.Persistence.Configurations
{
    public static class RepositoryConfigurationApplication
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();

            return services;
        }
    }
}
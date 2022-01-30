using DataStorage.Api.Interfaces.Repository;
using DataStorage.Api.Interfaces.Services;
using DataStorage.Api.Repositories;
using DataStorage.Api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DataStorage.Api.Dependencies
{
    public static class DependencyConfig
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IDataService, DataService>();
            services.AddSingleton<IDataRepository, DataRepository>();
            return services;
        }
    }
}

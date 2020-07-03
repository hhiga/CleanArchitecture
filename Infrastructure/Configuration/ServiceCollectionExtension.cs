using Core.Contracts.Gateways.Repositories;
using Infrastructure.Data.EntityFramework;
using Infrastructure.Data.EntityFramework.Entities;
using Infrastructure.Data.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            //services.AddDbContext<EntityFrameworkContext>();//configure to use mysql
            
            //services.AddTransient<IUserRepository, UserRepository>();
            //services.AddIdentityCore<AppUser>();
            
            return services;
        }
    }
}

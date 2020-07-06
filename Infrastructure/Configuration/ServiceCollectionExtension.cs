using Core.Contracts.Gateways.Repositories;
using Infrastructure.Data.EntityFramework;
using Infrastructure.Data.EntityFramework.Entities;
using Infrastructure.Data.EntityFramework.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }

        public static DbContextOptionsBuilder AddDbContextConfiguration(this DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=CleanArchitecture;user=root;password=Softing123.");
            return optionsBuilder;
        }
    }
}

using Core.Contracts.Gateways.Repositories;
using Core.UseCases;
using Infrastructure.Data.EntityFramework;
using Infrastructure.Data.EntityFramework.Entities;
using Infrastructure.Data.EntityFramework.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Infrastructure.Configuration
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<ILoginUserUseCase, LoginUserUseCase>();
            services.AddTransient<ILogoutUserUseCase, LogoutUserUseCase>();
            
            services.AddTransient<IRegisterUserUseCase, RegisterUserUseCase>();
            return services;
        }

        public static DbContextOptionsBuilder AddDbContextConfiguration(this DbContextOptionsBuilder optionsBuilder, string databaseConnection)
        {            
            optionsBuilder.UseMySql(databaseConnection);
            return optionsBuilder;
        }
    }
}

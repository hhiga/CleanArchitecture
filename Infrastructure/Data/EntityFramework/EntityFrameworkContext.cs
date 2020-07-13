using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infrastructure.Data.EntityFramework
{
    public class EntityFrameworkContext: IdentityDbContext<AppUser>
    {
        public EntityFrameworkContext(DbContextOptions<EntityFrameworkContext> options)
            :base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EntityFrameworkContext>
    {
        public EntityFrameworkContext CreateDbContext(string[] args)
        {            
            
            
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../CleanArchitecture.Web"))
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("database");
            var builder = new DbContextOptionsBuilder<EntityFrameworkContext>();
            builder.UseMySql(connectionString);
            return new EntityFrameworkContext(builder.Options);
        }
    }
}

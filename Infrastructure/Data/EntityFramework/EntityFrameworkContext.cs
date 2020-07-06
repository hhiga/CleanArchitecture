using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.EntityFramework
{
    public class EntityFrameworkContext: IdentityUserContext<AppUser>
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
            var builder = new DbContextOptionsBuilder<EntityFrameworkContext>();
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../MyCookingMaster.API/appsettings.json").Build(); 
            builder.UseMySql("server=localhost;database=CleanArchitecture;user=root;password=Softing123.");
            return new EntityFrameworkContext(builder.Options);
        }
    }
}

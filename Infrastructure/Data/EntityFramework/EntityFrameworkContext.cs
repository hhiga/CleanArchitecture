using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.EntityFramework
{
    public class EntityFrameworkContext: IdentityUserContext<AppUser>
    {
        public EntityFrameworkContext(DbContextOptions options)
            :base(options)
        {

        }
    }
}

using Core.Contracts.Gateways.Repositories;
using Core.Dto.Contracts.Gateways.Repositories;
using Core.Entities;
using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntityFramework.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUser> userManager;

        public UserRepository(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<CreateUserResponse> Create(User user, string password)
        {
            //TO-DO: use a mapper
            var newUser = new AppUser
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };

            var result = await userManager.CreateAsync(newUser, password);

            CreateUserResponse createUserResponse = new CreateUserResponse(result.Succeeded, result.Errors.Select(e => e.Description), newUser.Id);

            //if (result.Succeeded)
            //{
            //    createUserResponse = new CreateUserResponse(result.Succeeded, new List<string>(), newUser.Id);
            //}
            //else
            //{
            //    createUserResponse = new CreateUserResponse(result.Succeeded, new List<string>(), newUser.Id);
            //}
            return createUserResponse;
        }
    }
}

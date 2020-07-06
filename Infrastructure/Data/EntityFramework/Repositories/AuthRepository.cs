using Core.Contracts.Gateways.Repositories;
using Core.Dto.Contracts.Gateways.Repositories;
using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntityFramework.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SignInManager<AppUser> signInManager;
        public AuthRepository(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public async Task<LoginUserResponse> AuthenticateUser(string username, string password)
        {
            var response = await signInManager.PasswordSignInAsync(username, password, false, false);

            var loginUserResponse = new LoginUserResponse(response.Succeeded, response.Succeeded ? new List<string> { "Authentication granted" } : new List<string> { "Incorrect password or username" });

            return loginUserResponse;
        }
    }
}

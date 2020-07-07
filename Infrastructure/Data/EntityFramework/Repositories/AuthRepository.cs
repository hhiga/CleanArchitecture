using Core.Contracts.Gateways.Repositories;
using Core.Dto.Contracts.Gateways.Repositories;
using Core.Entities;
using Core.Errors;
using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Infrastructure.Data.EntityFramework.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        public AuthRepository(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<LoginUserResponse> AuthenticateUser(string username, string password)
        {
            var response = await signInManager.PasswordSignInAsync(username, password, false, false);

            var loginUserResponse = new LoginUserResponse(response.Succeeded, response.Succeeded ? new List<string> { "Authentication granted" } : new List<string> { "Incorrect password or username" });

            return loginUserResponse;
        }

        public async Task<LogoutUserResponse> LogOutUser(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            
            if(user == null)
            {
                throw new ApplicationException("User not found");
            }

            var result = await userManager.UpdateSecurityStampAsync(user);

            if (result.Succeeded)
                await signInManager.SignOutAsync();
            var logoutResponse = new LogoutUserResponse(result.Succeeded, result.Errors.Select(e => e.Description));

            return logoutResponse;
        }
    }
}

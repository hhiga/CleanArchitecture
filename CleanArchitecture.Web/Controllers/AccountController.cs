using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Contracts.Gateways.Repositories;
using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers
{        
    public class AccountController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly SignInManager<AppUser> signInManager;
        public AccountController(IUserRepository userRepository, SignInManager<AppUser> signInManager)
        {
            this.userRepository = userRepository;
            this.signInManager = signInManager;
        }
        
    }
}

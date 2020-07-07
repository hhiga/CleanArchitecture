using CleanArchitecture.Web.Models.ViewModels.Account;
using Core.Dto.UseCases.UserLogout;
using Core.Dto.UseCases.UserRegistration;
using Core.Errors;
using Core.UseCases;
using IdentityServer4.Services;
using Infrastructure.Data.EntityFramework.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRegisterUserUseCase registerUserUseCase;
        private readonly ILoginUserUseCase loginUserUseCase;
        private readonly ILogoutUserUseCase logoutUserUseCase;
        private readonly IIdentityServerInteractionService interactionService;
        
        public AccountController(IRegisterUserUseCase registerUserUseCase, ILoginUserUseCase loginUserUseCase, ILogoutUserUseCase logoutUserUseCase, IIdentityServerInteractionService interactionService)
        {
            this.registerUserUseCase = registerUserUseCase;
            this.loginUserUseCase = loginUserUseCase;
            this.interactionService = interactionService;
            this.logoutUserUseCase = logoutUserUseCase;
            
        }        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var authUserResponse = await loginUserUseCase.Handle(new Core.Dto.UseCases.UserLogin.UserLoginRequestMessage(loginViewModel.UserName, loginViewModel.Password));
                    if (authUserResponse.Success)
                    {
                        
                    }
                    return Redirect(loginViewModel.ReturnUrl);
                }
                catch(ApplicationAuthenticationException authException)
                {
                    ModelState.AddModelError(string.Empty, authException.Message);
                }
                
            }
            return View(loginViewModel);
        }
        [HttpGet]
        public IActionResult Register(string returnUrl)
        {
            return View(new RegisterViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {                
                UserRegistrationRequestMessage userRegistrationRequestMessage = new UserRegistrationRequestMessage(registerViewModel.Name, string.Empty, string.Empty, registerViewModel.UserName, registerViewModel.Password);
                var result = await registerUserUseCase.Handle(userRegistrationRequestMessage);
                if (result.Success)
                {
                    return Redirect(registerViewModel.ReturnUrl);
                }
            }
            return View(registerViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Logout(string logoutId)
        {            
            var logoutRequest = await interactionService.GetLogoutContextAsync(logoutId);
            UserLogoutRequestMessage userLogoutRequestMessage = new UserLogoutRequestMessage(logoutRequest.SubjectId);
            var result = await logoutUserUseCase.Handle(userLogoutRequestMessage);
            
            return Redirect(logoutRequest.PostLogoutRedirectUri);
        }

        public async Task<IActionResult> error(string errorId)
        {            
            var message = await interactionService.GetErrorContextAsync(errorId);
            return Json(message);
        }
    }
}

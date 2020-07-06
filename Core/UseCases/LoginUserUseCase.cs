using Core.Contracts;
using Core.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserLogin;
using Core.Errors;
using System;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class LoginUserUseCase : ILoginUserUseCase
    {
        private readonly IAuthRepository authRepository;
        public LoginUserUseCase(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }
        public async Task<UserLoginResponseMessage> Handle(UserLoginRequestMessage request)
        {
            var response = await authRepository.AuthenticateUser(request.UserName, request.Password);

            if(!response.Success)
                throw new ApplicationAuthenticationException(string.Format("Error with the repository :{0}", string.Join('.', response.Errors)));

            UserLoginResponseMessage responseMessage = new UserLoginResponseMessage(response.Success, "User Authenticated");
            return responseMessage;
        }
    }
}

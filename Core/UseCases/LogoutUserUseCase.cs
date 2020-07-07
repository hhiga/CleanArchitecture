using Core.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserLogout;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class LogoutUserUseCase : ILogoutUserUseCase
    {
        private readonly IAuthRepository authRepository;
        public LogoutUserUseCase(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }
        public async Task<UserLogoutResponseMesssage> Handle(UserLogoutRequestMessage request)
        {
            var response = await authRepository.LogOutUser(request.UserId);

            if (!response.Success)
                throw new ApplicationException("Error with logout.");

            var responseMessage = new UserLogoutResponseMesssage(response.Success, "Logout Succeed");
            return responseMessage;
        }
    }
}

using Core.Contracts;
using Core.Dto.UseCases.UserLogin;
using System;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class LoginUserUseCase : IRequestHandlerAsync<UserLoginRequestMessage, UserLoginResponseMessage>
    {
        public async Task<UserLoginResponseMessage> Handle(UserLoginRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }
}

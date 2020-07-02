using Core.Contracts;
using Core.Dto.UseCases.UserLogin;
using System;

namespace Core.UseCases
{
    public class LoginUserUseCase : IRequestHandler<UserLoginRequestMessage, UserLoginResponseMessage>
    {
        public UserLoginResponseMessage Handle(UserLoginRequestMessage request)
        {
            throw new NotImplementedException();
        }
    }
}

using Core.Contracts;
using Core.Dto.UseCases.UserLogin;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.UseCases
{
    public interface ILoginUserUseCase: IRequestHandlerAsync<UserLoginRequestMessage, UserLoginResponseMessage>
    {
    }
}

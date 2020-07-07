using Core.Contracts;
using Core.Dto.UseCases.UserLogout;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.UseCases
{
    public interface ILogoutUserUseCase: IRequestHandlerAsync<UserLogoutRequestMessage, UserLogoutResponseMesssage>
    {
    }
}

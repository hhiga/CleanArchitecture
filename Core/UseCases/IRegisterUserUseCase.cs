using Core.Contracts;
using Core.Dto.UseCases.UserRegistration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.UseCases
{
    public interface IRegisterUserUseCase : IRequestHandlerAsync<UserRegistrationRequestMessage, UserRegistrationResponseMessage>
    {
    }
}

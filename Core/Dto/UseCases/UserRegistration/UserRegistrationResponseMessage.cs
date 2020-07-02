using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.UseCases.UserRegistration
{
    public class UserRegistrationResponseMessage : ResponseMesssage
    {
        public UserRegistrationResponseMessage(bool success, string message) : base(success, message)
        {
        }
    }
}

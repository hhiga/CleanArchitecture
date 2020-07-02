using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.UseCases.UserLogin
{
    public class UserLoginResponseMessage : ResponseMesssage
    {
        public UserLoginResponseMessage(bool success, string message) : base(success, message)
        {
        }
    }
}

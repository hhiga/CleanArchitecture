using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.UseCases.UserLogout
{
    public class UserLogoutResponseMesssage: ResponseMesssage
    {
        public UserLogoutResponseMesssage(bool success, string message)
            :base(success, message)
        {

        }
    }
}

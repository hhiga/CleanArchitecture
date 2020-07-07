using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.UseCases.UserLogout
{
    public class UserLogoutRequestMessage
    {
        public string UserId { get; private set; }
        public UserLogoutRequestMessage(string userId)
        {
            this.UserId = userId;
        }
    }
}

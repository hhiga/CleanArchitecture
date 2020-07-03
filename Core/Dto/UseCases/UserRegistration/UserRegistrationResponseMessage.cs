using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.UseCases.UserRegistration
{
    public class UserRegistrationResponseMessage : ResponseMesssage
    {
        public string Id { get; }
        public UserRegistrationResponseMessage(bool success, string message, string Id) : base(success, message)
        {
            this.Id = Id;
        }
    }
}

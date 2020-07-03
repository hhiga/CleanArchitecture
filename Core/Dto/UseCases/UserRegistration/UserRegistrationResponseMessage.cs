using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.UseCases.UserRegistration
{
    public class UserRegistrationResponseMessage : ResponseMesssage
    {
        public int Id { get; }
        public UserRegistrationResponseMessage(bool success, string message, int Id) : base(success, message)
        {
            this.Id = Id;
        }
    }
}

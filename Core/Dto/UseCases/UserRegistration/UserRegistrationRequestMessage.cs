using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.UseCases.UserRegistration
{
    public class UserRegistrationRequestMessage
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string UserName { get; }
        public string Password { get; }

        public UserRegistrationRequestMessage(string firstName, string lastName, string email, string userName, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
        }
    }
}

using Core.Contracts;
using Core.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserRegistration;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.UseCases
{
    public class RegisterUserUseCase : IRequestHandler<UserRegistrationRequestMessage, UserRegistrationResponseMessage>
    {
        private readonly IUserRepository userRepository;
        public RegisterUserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public UserRegistrationResponseMessage Handle(UserRegistrationRequestMessage request)
        {
            //var response = await userRepository.Create(new User(request.FirstName, request.LastName, request.Email, request.UserName), request.Password);
            throw new NotImplementedException();
        }
    }
}

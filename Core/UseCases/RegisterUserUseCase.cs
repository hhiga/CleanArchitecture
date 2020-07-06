using Core.Contracts;
using Core.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserRegistration;
using Core.Entities;
using Core.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class RegisterUserUseCase : IRegisterUserUseCase
    {
        private readonly IUserRepository userRepository;
        public RegisterUserUseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<UserRegistrationResponseMessage> Handle(UserRegistrationRequestMessage request)
        {
            var response = await userRepository.Create(new User(request.FirstName, request.LastName, request.Email, request.UserName), request.Password);
            
            if (!response.Success)
                throw new ApplicationGatewayException(string.Format("Error with the repository :{0}", string.Join('.', response.Errors)));

            UserRegistrationResponseMessage userRegistrationResponse = new UserRegistrationResponseMessage(response.Success, "User Created Correctly.", response.Id);
            return userRegistrationResponse;
        }
    }
}

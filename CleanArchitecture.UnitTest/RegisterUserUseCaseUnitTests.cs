using Core.Contracts.Gateways.Repositories;
using Core.Dto.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserRegistration;
using Core.Entities;
using Core.UseCases;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class RegisterUserUseCaseUnitTests
    {
        [Fact]
        public void Can_Register_User()
        {
            //Arrange
            var mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository
                .Setup(repo => repo.Create(It.IsAny<User>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new CreateUserResponse(true, new List<string>())));

            var useCase = new RegisterUserUseCase(mockUserRepository.Object);

            var requestMessage = new UserRegistrationRequestMessage("Carlos", "Garcia", "carlos.garcia@mail.com", "CarlosGarcia", "Passw0rd-");

            //Act
            var responseMessage = useCase.Handle(requestMessage);

            //Assert
            Assert.True(responseMessage.Success);
        }
    }
}

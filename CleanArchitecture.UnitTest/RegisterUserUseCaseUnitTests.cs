using Core.Contracts.Gateways.Repositories;
using Core.Dto.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserRegistration;
using Core.Entities;
using Core.Errors;
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
                .Returns(Task.FromResult(new CreateUserResponse(true, new List<string>(),"asdasd")));

            var useCase = new RegisterUserUseCase(mockUserRepository.Object);

            var requestMessage = new UserRegistrationRequestMessage("Carlos", "Garcia", "carlos.garcia@mail.com", "CarlosGarcia", "Passw0rd-");

            //Act
            var responseMessage = useCase.Handle(requestMessage).Result;

            //Assert
            Assert.True(responseMessage.Success);
        }

        [Fact]
        public async Task Cannot_Register_User_With_Invalid_Password()
        {
            //Arrange
            var mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository
                .Setup(repo => repo.Create(It.IsAny<User>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new CreateUserResponse(false, new List<string>(), "asdasd")));

            var useCase = new RegisterUserUseCase(mockUserRepository.Object);

            var requestMessage = new UserRegistrationRequestMessage("Carlos", "Garcia", "carlos.garcia@mail.com", "CarlosGarcia", "");

            //Act and Assert
            await Assert.ThrowsAsync<ApplicationGatewayException>(() => useCase.Handle(requestMessage));
        }

        [Fact]
        public async Task Cannot_Register_User_With_Invalid_UserName()
        {
            //Arrange
            var mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository
                .Setup(repo => repo.Create(It.IsAny<User>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new CreateUserResponse(false, new List<string>(), "asdasd")));

            var useCase = new RegisterUserUseCase(mockUserRepository.Object);

            var requestMessage = new UserRegistrationRequestMessage("Carlos", "Garcia", "carlos.garcia@mail.com", "", "Passw0rd-");

            //Act and Assert
            await Assert.ThrowsAsync<ApplicationGatewayException>(() => useCase.Handle(requestMessage));
        }
    }
}

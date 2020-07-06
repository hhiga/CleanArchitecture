using Core.Contracts.Gateways.Repositories;
using Core.Dto.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserLogin;
using Core.Errors;
using Core.UseCases;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.UnitTest
{
    public class LoginUserUseCaseUnitTest
    {
        [Fact]
        public void Can_Login_User()
        {
            //Arrange
            var mockRepository = new Mock<IAuthRepository>();
            mockRepository
                .Setup(repo => repo.AuthenticateUser(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new LoginUserResponse(true, new List<string>())));

            var useCase = new LoginUserUseCase(mockRepository.Object);
            var requestMessage = new UserLoginRequestMessage("CarlosGarcia", "Passw0rd-");

            //Act
            var responseMessage = useCase.Handle(requestMessage).Result;

            //Assert
            Assert.True(responseMessage.Success);
        }

        [Fact]
        public async Task Cannot_Login_User()
        {
            //Arrange
            var mockRepository = new Mock<IAuthRepository>();
            mockRepository
                .Setup(repo => repo.AuthenticateUser(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(Task.FromResult(new LoginUserResponse(false, new List<string>())));

            var useCase = new LoginUserUseCase(mockRepository.Object);
            var requestMessage = new UserLoginRequestMessage("CarlosGarcia", "Passw0rd-");

            //Act and Assert
            await Assert.ThrowsAsync<ApplicationAuthenticationException>(() => useCase.Handle(requestMessage));
        }
    }
}

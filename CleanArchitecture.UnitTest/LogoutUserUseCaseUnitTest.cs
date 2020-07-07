using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts.Gateways.Repositories;
using Core.Dto.Contracts.Gateways.Repositories;
using Core.Dto.UseCases.UserLogout;
using Core.UseCases;
using Moq;
using Xunit;

namespace CleanArchitecture.UnitTest
{

    public class LogoutUserUseCaseUnitTest
    {
        [Fact]
        public void Can_Logut()
        {
            //Arrange
            var moq = new Mock<IAuthRepository>();
            moq
                .Setup(repo => repo.LogOutUser(It.IsAny<string>()))
                .Returns(Task.FromResult(new LogoutUserResponse(true, new List<string>())));
            var useCase = new LogoutUserUseCase(moq.Object);
            var requestMessage = new UserLogoutRequestMessage("IdUser");

            //Act
            var responseMessage = useCase.Handle(requestMessage).Result;

            //Assert
            Assert.True(responseMessage.Success);
        }

        [Fact]
        public async Task Cannot_Logut()
        {
            //Arrange
            var moq = new Mock<IAuthRepository>();
            moq
                .Setup(repo => repo.LogOutUser(It.IsAny<string>()))
                .Returns(Task.FromResult(new LogoutUserResponse(false, new List<string>())));
            var useCase = new LogoutUserUseCase(moq.Object);
            var requestMessage = new UserLogoutRequestMessage("IdUser");

            //Act and Assert
            await Assert.ThrowsAsync<ApplicationException>(() => useCase.Handle(requestMessage));
            
        }
    }
}

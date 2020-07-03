using Core.Contracts;

namespace Core.Dto.UseCases.UserLogin
{
    public class UserLoginRequestMessage
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public UserLoginRequestMessage(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}

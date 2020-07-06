using Core.Dto.Contracts.Gateways.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Gateways.Repositories
{
    public interface IAuthRepository
    {
        Task<LoginUserResponse> AuthenticateUser(string username, string password);
    }
}

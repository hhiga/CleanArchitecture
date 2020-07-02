using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.Contracts.Gateways.Repositories
{
    public class CreateUserResponse : BaseGatewayResponse
    {
        public CreateUserResponse(bool success, IEnumerable<string> errors) : base(success, errors)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.Contracts.Gateways.Repositories
{
    public class LogoutUserResponse: BaseGatewayResponse
    {
        public LogoutUserResponse(bool success, IEnumerable<string> errors)
            :base(success, errors)
        {

        }
    }
}

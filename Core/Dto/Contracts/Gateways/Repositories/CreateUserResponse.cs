using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.Contracts.Gateways.Repositories
{
    public class CreateUserResponse : BaseGatewayResponse
    {
        public string Id { get; }
        public CreateUserResponse()
        {

        }
        public CreateUserResponse(bool success, IEnumerable<string> errors, string Id) : base(success, errors)
        {
            this.Id = Id;
        }
    }
}

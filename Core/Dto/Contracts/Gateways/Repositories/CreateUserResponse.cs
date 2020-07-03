using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.Contracts.Gateways.Repositories
{
    public class CreateUserResponse : BaseGatewayResponse
    {
        public int Id { get; }
        public CreateUserResponse(bool success, IEnumerable<string> errors, int Id) : base(success, errors)
        {
            this.Id = Id;
        }
    }
}

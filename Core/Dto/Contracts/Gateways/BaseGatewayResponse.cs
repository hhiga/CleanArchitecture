using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dto.Contracts.Gateways
{
    public abstract class BaseGatewayResponse
    {
        public bool Success { get; }
        public IEnumerable<string> Errors { get; }
        public BaseGatewayResponse(bool success, IEnumerable<string> errors)
        {
            this.Success = success;
            this.Errors = errors;
        }
    }
}

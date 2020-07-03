using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Errors
{
    public class ApplicationGatewayException: Exception
    {
        public ApplicationGatewayException(string gatewayErrorMessage)
            :base(gatewayErrorMessage)
        {

        }
    }
}

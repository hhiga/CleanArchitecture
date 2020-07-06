using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Errors
{
    public class ApplicationAuthenticationException: Exception
    {
        public ApplicationAuthenticationException(string message)
            :base(message)
        {

        }
    }
}

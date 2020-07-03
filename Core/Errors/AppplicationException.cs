using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Errors
{
    public class AppplicationException: Exception
    {
        public AppplicationException(string businessMessage)
            :base(businessMessage)
        {
        }
    }
}

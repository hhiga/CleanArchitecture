using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public abstract class ResponseMesssage
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public ResponseMesssage(bool success, string message)
        {
            this.Success = success;
            this.Message = message;
        }
    }
}

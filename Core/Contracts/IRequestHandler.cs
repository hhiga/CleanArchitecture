using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IRequestHandler <TRequest, TResponse>
        where TRequest: class
        where TResponse: class
    {
        TResponse Handle(TRequest request);
    }
}

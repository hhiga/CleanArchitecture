using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IRequestHandlerAsync<TRequest, TResponse>
        where TRequest: class
        where TResponse: class        
    {
        Task<TResponse> Handle(TRequest request);
    }
}

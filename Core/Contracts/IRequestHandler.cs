using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    /// <summary>
    /// Defines a handler for a request. The handler returns a response.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request being handled</typeparam>
    /// <typeparam name="TResponse">The type of the response from the handler</typeparam>
    public interface IRequestHandler <in TRequest, out TResponse>
        where TRequest: IRequest<TResponse>
    {
        TResponse Handle(TRequest request);
    }
    /// <summary>
    /// Defines a handler for a request. The handler returns void.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request being handled</typeparam>
    public interface IRequestHandler <in TRequest>
        where TRequest : IRequest
    {
        void Handle(TRequest request);
    }
    
}

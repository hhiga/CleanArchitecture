namespace Core.Contracts
{
    /// <summary>
    /// Interface to represent a Request with a void response
    /// </summary>
    public interface IRequest
    {
    }
    /// <summary>
    /// Interface to represent a Request with a Response
    /// </summary>
    /// <typeparam name="TResponse">The type of the response</typeparam>
    public interface IRequest<out TResponse>
    {
    }
}

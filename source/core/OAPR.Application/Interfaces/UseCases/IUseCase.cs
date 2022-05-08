namespace OAPR.Application.Interfaces.UseCases
{
    public interface IUseCase<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
        Task<TResponse> ExecuteAsync(TRequest request);
    }

    public interface IUseCase<TRequest>
    {
        Task ExecuteAsync(TRequest request);
    }
}
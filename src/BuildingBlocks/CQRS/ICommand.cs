using MediatR;

namespace BuildingBlocks.CQRS;

// Unit means does not return a response
public interface ICommand : ICommand<Unit>
{}

public interface ICommand<out TResponse>: IRequest<TResponse>
{

}
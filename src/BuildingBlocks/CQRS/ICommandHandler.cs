using MediatR;

namespace BuildingBlocks.CQRS;

// Unit is a void type for MediatR. It means no return.
public interface ICommandHandler<in TCommand> : ICommandHandler<TCommand, Unit>
    where TCommand : ICommand<Unit>
{
}

public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{

}


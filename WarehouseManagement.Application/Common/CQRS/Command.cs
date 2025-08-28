using MediatR;

namespace WarehouseManagement.Application.Common.CQRS;

public interface ICommand<out T> : IRequest<T> {
    
}

using MediatR;

namespace WarehouseManagement.Application.Common.CQRS;

public interface IQuery<out T> : IRequest<T> {
    
}

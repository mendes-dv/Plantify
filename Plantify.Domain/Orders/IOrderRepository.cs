using Plantify.Domain.Plants;
using Plantify.Domain.Users;

namespace Plantify.Domain.Orders;

public interface IOrderRepository 
{
    Task<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    void Add(Order order);
}
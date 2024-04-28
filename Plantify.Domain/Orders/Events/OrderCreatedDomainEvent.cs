using Plantify.Domain.Abstractions;

namespace Plantify.Domain.Orders.Events;

public sealed record OrderCreatedDomainEvent(Guid PlantId) : IDomainEvent;
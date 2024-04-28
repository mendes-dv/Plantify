using Plantify.Domain.Abstractions;

namespace Plantify.Domain.Plants.Events;

public sealed record PlantCreatedDomainEvent(Guid PlantId) : IDomainEvent;
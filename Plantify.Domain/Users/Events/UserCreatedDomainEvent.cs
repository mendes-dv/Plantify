using Plantify.Domain.Abstractions;

namespace Plantify.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
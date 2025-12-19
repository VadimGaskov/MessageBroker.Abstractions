using MessageBroker.Abstractions.Interfaces;

namespace MessageBroker.Abstractions;

public record BaseIntegrationEvent() : IIntegrationEvent
{
    public Guid EventId { get; init; } = Guid.NewGuid();
    public DateTime OccuredAt { get; init; } = DateTime.UtcNow;
}
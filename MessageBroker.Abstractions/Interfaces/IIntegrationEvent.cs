namespace MessageBroker.Abstractions.Interfaces;

public interface IIntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccuredAt { get; init; }
}
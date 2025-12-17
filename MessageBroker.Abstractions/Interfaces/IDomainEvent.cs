namespace MessageBroker.Abstractions.Interfaces;

public interface IDomainEvent
{
    public Guid EventId { get; init; }
    public DateTime OccuredAt { get; init; }
    public string EventName { get; init; }
}
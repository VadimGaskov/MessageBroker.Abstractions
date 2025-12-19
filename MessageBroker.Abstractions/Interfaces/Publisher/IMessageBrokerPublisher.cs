namespace MessageBroker.Abstractions.Interfaces.Publisher;

public interface IMessageBrokerPublisher
{
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : IIntegrationEvent;
}
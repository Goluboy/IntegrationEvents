using MassTransit;

namespace IntegrationEvents.IntegrationEvents;

public abstract record IntegrationEvent
{
    public Guid EventId { get; init; }
    public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
    public Guid CorrelationId { get; init; } // = OrderId для связки шагов SAGA

    protected IntegrationEvent()
    {
        EventId = NewId.NextSequentialGuid();
        OccurredOn = DateTime.UtcNow;
    }
    protected IntegrationEvent(Guid correlationId) : this()
    {
        CorrelationId = correlationId;
    }
}

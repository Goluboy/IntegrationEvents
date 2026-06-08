namespace IntegrationEvents.IntegrationEvents;

public record OrderCancelledEvent : IntegrationEvent
{
    public string Reason { get; init; } = string.Empty;

    public List<Guid> ItemsToRelease { get; init; } = new();
}
namespace IntegrationEvents.IntegrationEvents;

public record StockReservationFailedEvent : IntegrationEvent
{
    public string Reason { get; init; } = string.Empty;

    public List<Guid> FailedProductIds { get; init; } = new();
}
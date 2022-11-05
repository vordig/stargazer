using Stargazer.Domain.Database;
using Stargazer.Domain.Enums;

namespace Stargazer.Domain;

public record Item : DatabaseEntity
{
    public Guid UserId { get; set; }
    public Guid ProjectId { get; set; }
    public Guid TypeId { get; init; }
    public string Article { get; init; } = string.Empty; // HR-M-1d9ca621
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Stage { get; set; } = string.Empty;
    public double Quantity { get; set; }
    public string Measurement { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public decimal Price { get; set; }
    public ItemStatus Status { get; set; }
    public Guid? InvoiceId { get; set; }
}
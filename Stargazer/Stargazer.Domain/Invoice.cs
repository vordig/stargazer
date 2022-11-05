using Stargazer.Domain.Database;
using Stargazer.Domain.Enums;

namespace Stargazer.Domain;

public record Invoice : DatabaseEntity
{
    public Guid UserId { get; set; }
    public Guid ProjectId { get; set; }
    public InvoiceStatus Status { get; set; }
    public decimal Price { get; set; }
    public IEnumerable<Guid> Items { get; set; } = Enumerable.Empty<Guid>();
}
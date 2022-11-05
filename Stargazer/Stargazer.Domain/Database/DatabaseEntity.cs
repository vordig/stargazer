namespace Stargazer.Domain.Database;

public abstract record DatabaseEntity
{
    public Guid Id { get; private init; } = Guid.NewGuid();
    public Audit Audit { get; private init; } = Audit.NewAudit();
}
namespace Stargazer.Domain.Database;

public record Audit
{
    public DateTime CreatedAt { get; private init; }
    public DateTime UpdatedAt { get; private set; }

    public void Update()
    {
        UpdatedAt = DateTime.UtcNow;
    }

    public static Audit NewAudit()
    {
        var currentTime = DateTime.UtcNow;
        return new Audit
        {
            CreatedAt = currentTime,
            UpdatedAt = currentTime
        };
    }
}
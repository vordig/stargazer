﻿using Stargazer.Domain.Database;

namespace Stargazer.Domain;

public record Type : DatabaseEntity
{
    public Guid UserId { get; set; }
    public Guid ProjectId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
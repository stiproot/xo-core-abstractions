﻿namespace Xo.Core.Abstractions;

public class BaseCommandResult : ICommandResult
{
    public long Id { get; init; } = -1;
}

using System;

namespace Tappau.DateTimeProvider.Abstractions
{
    public interface IDateTimeOffsetProvider
    {
        DateTimeOffset UtcNow { get; }
        DateTimeOffset Now { get; }
    }
}
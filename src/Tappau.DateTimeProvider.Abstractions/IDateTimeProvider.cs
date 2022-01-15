using System;

namespace Tappau.DateTimeProvider.Abstractions
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
        DateTime Now { get; }
    }
}

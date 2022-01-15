using System;
using Tappau.DateTimeProvider.Abstractions;

namespace Tappau.DateTimeProvider
{
    internal class DateTimeOffsetProvider : IDateTimeOffsetProvider
    {
        public DateTimeOffset UtcNow => DateTimeOffset.UtcNow;

        public DateTimeOffset Now => DateTimeOffset.Now;
    }
}
using System;
using Tappau.DateTimeProvider.Abstractions;

namespace Tappau.DateTimeProvider
{
    internal class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
        public DateTime Now => DateTime.Now;
    }
}

using Portfolio.Application.Common.Interfaces.Services;

namespace Portfolio.Infrastructure.Services;

/// <summary name="DateTimeProvider">
/// Implementation of <see cref="IDateTimeProvider"/>.
/// </summary>
public class DateTimeProvider : IDateTimeProvider
{
    /// <summary>
    /// Gets the current date and time in UTC.
    /// </summary>
    public DateTime UtcNow => DateTime.UtcNow;
}
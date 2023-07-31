namespace Portfolio.Application.Common.Interfaces.Services;

/// <summary name="IDateTimeProvider">
/// Provides a way to get the current date
/// and time in UTC, accross the application.
/// UtcNow is used instead of Now to avoid
/// any timezone issues when storing dates and times
/// in the database.
/// </summary>
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
using FieldOps.Domain.ValueObjects;

namespace FieldOps.Domain.Entities;

public sealed class WorkTask
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string? Description { get; private set; }
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }
    public int RequiredHours { get; private set; }
    public DateOnly EarliestDate { get; private set; }
    public DateOnly LatestDate { get; private set; }
    public TimeOnly WorkDayStart { get; private set; }
    public TimeOnly WorkDayEnd { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public WeatherRequirements WeatherRequirements { get; private set; } = null!;

    private WorkTask() { }

    public WorkTask(
        string name,
        string? description,
        double latitude,
        double longitude,
        int requiredHours,
        DateOnly earliestDate,
        DateOnly latestDate,
        TimeOnly workDayStart,
        TimeOnly workDayEnd,
        WeatherRequirements weather)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");

        if (!double.IsFinite(latitude) || latitude < -90 || latitude > 90)
            throw new ArgumentOutOfRangeException(nameof(latitude));

        if (!double.IsFinite(longitude) || longitude < -180 || longitude > 180)
            throw new ArgumentOutOfRangeException(nameof(longitude));

        if (requiredHours <= 0)
            throw new ArgumentException("Required hours must be at least 1 hour.");

        if (earliestDate < DateOnly.FromDateTime(DateTime.Today))
            throw new ArgumentException("Earliest date cannot be in the past.");

        if (earliestDate > latestDate)
            throw new ArgumentException("Earliest date cannot be later than latest date.");

        if (workDayStart >= workDayEnd)
            throw new ArgumentException("Work day start must be earlier than work day end.");

        if (weather is null)
            throw new ArgumentNullException("Weather requirements cannot be empty.");

        Id = Guid.NewGuid();
        Name = name.Trim();
        Description = description;
        Latitude = latitude;
        Longitude = longitude;
        RequiredHours = requiredHours;
        EarliestDate = earliestDate;
        LatestDate = latestDate;
        WorkDayStart = workDayStart;
        WorkDayEnd = workDayEnd;
        CreatedAt = DateTimeOffset.UtcNow;
        WeatherRequirements = weather;
    }
}

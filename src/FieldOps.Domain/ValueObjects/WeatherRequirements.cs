namespace FieldOps.Domain.ValueObjects;

public sealed class WeatherRequirements
{
    public int MinTemperature { get; private set; }
    public int MaxTemperature { get; private set; }
    public int MaxWindSpeed { get; private set; }
    public double MaxPrecipitation { get; private set; }

    private WeatherRequirements() {}

    public WeatherRequirements(
        Guid workTaskId,
        int minTemperature,
        int maxTemperature,
        int maxWindSpeed,
        double maxPrecipitation)
    {
        if (workTaskId == Guid.Empty)
            throw new ArgumentException("Id of work task cannot be empty.");

        if (minTemperature > maxTemperature)
            throw new ArgumentException("Minimal temperature cannot be higher than maximum temperature.");

        if (maxWindSpeed < 0)
            throw new ArgumentOutOfRangeException(nameof(maxWindSpeed), "Maximum wind speed cannot be lower than 0 kmph.");

        if (maxPrecipitation < 0)
            throw new ArgumentOutOfRangeException(nameof(maxPrecipitation), "Maximum precipitation cannot be lower than 0.");

        MinTemperature = minTemperature;
        MaxTemperature = maxTemperature;
        MaxWindSpeed = maxWindSpeed;
        MaxPrecipitation = maxPrecipitation;
    }
}

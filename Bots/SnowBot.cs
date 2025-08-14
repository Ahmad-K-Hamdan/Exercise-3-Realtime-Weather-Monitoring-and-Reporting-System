namespace Realtime_Weather_Monitoring_and_Reporting_System.Bots;

public class SnowBot : Bot
{
    public int TemperatureThreshold { get; set; }

    public SnowBot(bool enabled, int temperatureThreshold, string message)
    {
        Enabled = enabled;
        TemperatureThreshold = temperatureThreshold;
        Message = message;
    }
}

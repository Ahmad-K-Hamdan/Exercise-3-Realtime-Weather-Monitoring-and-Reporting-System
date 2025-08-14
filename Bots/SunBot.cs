namespace Realtime_Weather_Monitoring_and_Reporting_System.Bots;

public class SunBot : Bot
{
    public int TemperatureThreshold { get; set; }

    public SunBot(bool enabled, int temperatureThreshold, string message)
    {
        Enabled = enabled;
        TemperatureThreshold = temperatureThreshold;
        Message = message;
    }
}

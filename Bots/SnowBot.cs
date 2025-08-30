using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

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

    public override void Update(WeatherData data)
    {
        if (Enabled && data.Temperature <= TemperatureThreshold)
        {
            Console.WriteLine("SnowBot activated!");
            Console.WriteLine($"SnowBot: \"{Message}\"\n");
        }
    }
}

using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

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

    public override void Update(WeatherData data)
    {
        if (Enabled && data.Temperature >= TemperatureThreshold)
        {
            Console.WriteLine("SunBot activated!");
            Console.WriteLine($"SunBot: \"{Message}\"");
        }
    }
}

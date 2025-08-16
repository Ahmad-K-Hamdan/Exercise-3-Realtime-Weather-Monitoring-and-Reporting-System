using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Bots;

public class RainBot : Bot
{
    public int HumidityThreshold { get; set; }

    public RainBot(bool enabled, int humidityThreshold, string message)
    {
        Enabled = enabled;
        HumidityThreshold = humidityThreshold;
        Message = message;
    }

    public override void Update(WeatherData data)
    {
        if (Enabled && data.Humidity >= HumidityThreshold)
        {
            Console.WriteLine("RainBot activated!");
            Console.WriteLine($"RainBot: \"{Message}\"");
        }
    }
}

using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Bots;

public abstract class Bot
{
    public bool Enabled { get; set; }
    public string? Message { get; set; }

    public abstract void Update(WeatherData data);
}

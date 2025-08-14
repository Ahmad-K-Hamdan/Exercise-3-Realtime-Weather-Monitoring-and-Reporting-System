namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class WeatherData
{
    public string Location { get; }
    public decimal Temperature { get; }
    public decimal Humidity { get; }

    public WeatherData(string location, decimal temperature, decimal humidity)
    {
        Location = location;
        Temperature = temperature;
        Humidity = humidity;
    }
}

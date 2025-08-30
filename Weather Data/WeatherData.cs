namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class WeatherData
{
    required public string Location { get; set; }
    public decimal Temperature { get; set; }
    public decimal Humidity { get; set; }

    public WeatherData()
    {
    }

    public WeatherData(string location, decimal temperature, decimal humidity)
    {
        Location = location;
        Temperature = temperature;
        Humidity = humidity;
    }
}

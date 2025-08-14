using System.Text.Json;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class JSONParser : IWeatherDataParser
{
    public WeatherData ParseData(string data)
    {
        var weatherData = JsonSerializer.Deserialize<WeatherData>(data)!;
        return weatherData;
    }
}

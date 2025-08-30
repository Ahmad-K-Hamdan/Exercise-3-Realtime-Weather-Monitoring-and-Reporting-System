using System.Text.Json;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class JSONParser : IWeatherDataParser
{
    public WeatherData ParseData(string data)
    {
        try
        {
            var weatherData = JsonSerializer.Deserialize<WeatherData>(data)!;
            return weatherData;
        }
        catch (InvalidOperationException ex)
        {
            throw new FormatException("Failed to parse JSON data", ex);
        }
    }

    public bool CanParse(string input)
    {
        return input.Trim().StartsWith('{');
    }
}

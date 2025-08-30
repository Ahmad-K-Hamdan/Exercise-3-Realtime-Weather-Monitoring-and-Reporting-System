using System.Xml.Serialization;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class XMLParser : IWeatherDataParser
{
    public WeatherData ParseData(string data)
    {
        try
        {
            var serializer = new XmlSerializer(typeof(WeatherData));
            using var reader = new StringReader(data);
            var weatherData = (WeatherData)serializer.Deserialize(reader)!;
            return weatherData;
        }
        catch (InvalidOperationException ex)
        {
            throw new FormatException("Failed to parse XML data", ex);
        }
    }

    public bool CanParse(string input)
    {
        return input.Trim().StartsWith('<');
    }
}

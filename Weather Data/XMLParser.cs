using System.Xml.Serialization;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class XMLParser : IWeatherDataParser
{
    public WeatherData ParseData(string data)
    {
        var serializer = new XmlSerializer(typeof(WeatherData));
        using var reader = new StringReader(data);
        var weatherData = (WeatherData)serializer.Deserialize(reader)!;
        return weatherData;
    }
}

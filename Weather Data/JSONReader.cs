namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class JSONReader : IWeatherDataParser
{
    public void ParseData(string data)
    {
        Console.WriteLine("Parsing JSON data");
    }
}

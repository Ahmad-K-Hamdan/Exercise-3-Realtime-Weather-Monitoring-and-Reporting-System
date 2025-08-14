namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public interface IWeatherDataParser
{
    WeatherData ParseData(string data);
}

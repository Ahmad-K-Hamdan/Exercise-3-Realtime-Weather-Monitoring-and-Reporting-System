using Realtime_Weather_Monitoring_and_Reporting_System.Bots;
using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Observer;

public interface IWeatherDataSubject
{
    void Attach(Bot observer);
    void Detach(Bot observer);
    void Activate(WeatherData data);
}


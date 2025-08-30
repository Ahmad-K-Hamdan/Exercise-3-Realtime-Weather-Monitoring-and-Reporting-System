using Realtime_Weather_Monitoring_and_Reporting_System.Bots;
using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Observer;

public class WeatherStation : IWeatherDataSubject
{
    private readonly List<Bot> _observers = new();

    public void Attach(Bot observer) => _observers.Add(observer);
    public void Detach(Bot observer) => _observers.Remove(observer);

    public void Activate(WeatherData data)
    {
        foreach (var observer in _observers)
        {
            observer.Update(data);
        }
    }
}

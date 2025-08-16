using System;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class ParserPicker
{
    private readonly IEnumerable<IWeatherDataParser> _parsers;

    public ParserPicker(IEnumerable<IWeatherDataParser> parsers)
    {
        _parsers = parsers;
    }

    public IWeatherDataParser? GetParser(string input) => _parsers.FirstOrDefault(p => p.CanParse(input));
}

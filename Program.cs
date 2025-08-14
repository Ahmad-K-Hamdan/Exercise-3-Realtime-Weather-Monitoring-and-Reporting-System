using Realtime_Weather_Monitoring_and_Reporting_System.Bots;
using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

var inputJSON =
"""
  {
  "Location": "Ramallah",
  "Temperature": 23.0,
  "Humidity": 85.0 
  }
""";

var inputXML =
"""
<WeatherData>
  <Location>City Name</Location>
  <Temperature>23.0</Temperature>
  <Humidity>85.0</Humidity>
</WeatherData>
""";


IWeatherDataParser parser = new JSONParser();
var data = parser.ParseData(inputJSON);

parser = new XMLParser();
data = parser.ParseData(inputXML);

var botsConfiguration = new BotsConfiguration();
botsConfiguration.LoadConfiguration("Bots/config.json");

System.Console.WriteLine(botsConfiguration.RainBot.Enabled);
System.Console.WriteLine(botsConfiguration.RainBot.HumidityThreshold);
System.Console.WriteLine(botsConfiguration.RainBot.Message);
System.Console.WriteLine();
System.Console.WriteLine(botsConfiguration.SunBot.Enabled);
System.Console.WriteLine(botsConfiguration.SunBot.TemperatureThreshold);
System.Console.WriteLine(botsConfiguration.SunBot.Message);
System.Console.WriteLine();
System.Console.WriteLine(botsConfiguration.SnowBot.Enabled);
System.Console.WriteLine(botsConfiguration.SnowBot.TemperatureThreshold);
System.Console.WriteLine(botsConfiguration.SnowBot.Message);

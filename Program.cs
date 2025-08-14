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

Console.WriteLine(data.Temperature);
Console.WriteLine(data.Location);
Console.WriteLine(data.Humidity);

parser = new XMLParser();
data = parser.ParseData(inputXML);

Console.WriteLine(data.Temperature);
Console.WriteLine(data.Location);
Console.WriteLine(data.Humidity);

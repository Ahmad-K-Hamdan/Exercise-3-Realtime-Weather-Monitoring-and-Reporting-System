using Realtime_Weather_Monitoring_and_Reporting_System.Bots;
using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the weather monitoring and reporting service");

        var botsConfiguration = new BotsConfiguration();
        botsConfiguration.LoadConfiguration("Bots/config.json");

        var parsers = new List<IWeatherDataParser> { new JSONParser(), new XMLParser() };

        while (true)
        {
            var input = ReadUserInput();
            if (input == null) break;

            var parser = SelectParser(input!, parsers);
            if (parser == null)
            {
                Console.WriteLine("\nInvalid Input. Supported formats: JSON, XML.");
                continue;
            }

            try
            {
                WeatherData weatherData = parser.ParseData(input!);
                Console.WriteLine("\nParsed successfully!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }

        Console.WriteLine("Good Bye!");
    }

    static string? ReadUserInput()
    {
        Console.WriteLine("Enter weather data (q to quit):");

        List<string> lines = new List<string>();
        string? line;

        while (!string.IsNullOrEmpty(line = Console.ReadLine()) && line != "q")
        {
            lines.Add(line);
        }

        if (line == "q")
        {
            return null;
        }

        return string.Join(Environment.NewLine, lines);
    }

    static IWeatherDataParser? SelectParser(string input, List<IWeatherDataParser> parsers) => parsers.FirstOrDefault(parser => parser.CanParse(input));
}

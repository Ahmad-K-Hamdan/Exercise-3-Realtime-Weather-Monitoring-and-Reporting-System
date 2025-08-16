using Realtime_Weather_Monitoring_and_Reporting_System.Bots;
using Realtime_Weather_Monitoring_and_Reporting_System.Weather_Data;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the weather monitoring and reporting service");
        Console.WriteLine("Enter weather data (q to quit):");

        var botsConfiguration = new BotsConfiguration();
        botsConfiguration.LoadConfiguration("Bots/config.json");

        var parsers = new List<IWeatherDataParser> { new JSONParser(), new XMLParser() };

        string input;
        while (true)
        {
            List<string> lines = new List<string>();
            string? line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()) && line != "q")
            {
                lines.Add(line);
            }

            if (line == "q") break;
            input = string.Join(Environment.NewLine, lines);

            var parser = parsers.FirstOrDefault(parser => parser.CanParse(input));
            if (parser == null)
            {
                Console.WriteLine("\nInvalid Input. Parser not found.");
                Console.WriteLine("Enter weather data (q to quit):");
                continue;
            }

            WeatherData weatherData = null!;
            try
            {
                weatherData = parser.ParseData(input);
                Console.WriteLine("\nParsed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                continue;
            }

            Console.WriteLine("Enter weather data (q to quit):");
        }

        Console.WriteLine("Good Bye!");
    }
}

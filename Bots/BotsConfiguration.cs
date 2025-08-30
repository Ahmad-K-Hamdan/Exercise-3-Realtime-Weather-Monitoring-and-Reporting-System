using System.Text.Json;

namespace Realtime_Weather_Monitoring_and_Reporting_System.Bots;

public class BotsConfiguration
{
    public SunBot SunBot { get; set; } = null!;
    public RainBot RainBot { get; set; } = null!;
    public SnowBot SnowBot { get; set; } = null!;
    public List<Bot> Bots { get; private set; } = new();

    public void LoadConfiguration(string filePath)
    {
        var rawData = File.ReadAllText(filePath);
        var deserializedData = JsonSerializer.Deserialize<BotsConfiguration>(rawData)
                ?? throw new InvalidOperationException("Failed to read bots config");

        SunBot = deserializedData.SunBot;
        RainBot = deserializedData.RainBot;
        SnowBot = deserializedData.SnowBot;

        Bots = new List<Bot> { SunBot, RainBot, SnowBot };
    }
}

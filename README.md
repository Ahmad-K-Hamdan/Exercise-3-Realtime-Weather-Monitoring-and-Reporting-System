# Exercise 3: Realtime Weather Monitoring and Reporting System

## Overview

This C# console application simulates a real-time weather monitoring and reporting service. It receives and processes raw weather data in multiple formats (JSON, XML, etc.) from various weather stations for different locations. The system includes various types of "weather bots," each configured to behave differently based on weather updates it receives.

---

## Features

- **Multi-format Input:** Accepts weather data in both JSON and XML formats.
- **Configurable Bots:** Includes RainBot, SunBot, and SnowBot, each with customizable thresholds, messages, and enabled/disabled state.
- **Flexible Configuration:** All bot settings are managed through a JSON configuration file.
- **Extensible Design:** Easily add new data formats and bot types by applying SOLID principles (especially the Open/Closed principle).
- **Design Patterns:** Implements Observer and Strategy design patterns for reactive and modular bot behavior.

---

## Supported Input Formats

### JSON Format

```json
{
  "Location": "City Name",
  "Temperature": 23.0,
  "Humidity": 85.0
}
```

### XML Format

```xml
<WeatherData>
  <Location>City Name</Location>
  <Temperature>23.0</Temperature>
  <Humidity>85.0</Humidity>
</WeatherData>
```

---

## Bot Types & Activation

- **RainBot:** Activated when humidity exceeds its configured threshold.
- **SunBot:** Activated when temperature rises above its configured threshold.
- **SnowBot:** Activated when temperature drops below its configured threshold.

When activated, each bot prints a custom message.

---

## Configuration

The application uses a JSON configuration file to control bot behavior. Example:

```json
{
  "RainBot": {
    "enabled": true,
    "humidityThreshold": 70,
    "message": "It looks like it's about to pour down!"
  },
  "SunBot": {
    "enabled": true,
    "temperatureThreshold": 30,
    "message": "Wow, it's a scorcher out there!"
  },
  "SnowBot": {
    "enabled": false,
    "temperatureThreshold": 0,
    "message": "Brrr, it's getting chilly!"
  }
}
```

- `enabled`: Turns the bot on or off.
- `humidityThreshold` / `temperatureThreshold`: Sets the value to trigger the bot.
- `message`: The output when the bot is activated.

---

## Example Usage

1. **Start the application.**
2. **Prompt:** `Enter weather data:`
3. **Input (JSON):** `{"Location": "City Name", "Temperature": 32, "Humidity": 40}`
   <br>**Input (XML):** `<WeatherData><Location>City Name</Location><Temperature>32</Temperature><Humidity>40</Humidity></WeatherData>`
4. **Output (if SunBot is triggered):**
    ```
    SunBot activated!
    SunBot: "Wow, it's a scorcher out there!"
    ```

---

## Design Principles

- **Open/Closed Principle:** New data formats and bot types can be added with minimal code changes.
- **Observer Pattern:** Bots observe weather data updates and react when relevant.
- **Strategy Pattern:** Each bot uses its own activation strategy and message.

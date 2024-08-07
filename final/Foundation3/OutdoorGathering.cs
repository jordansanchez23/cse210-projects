public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GenerateFullMessage()
    {
        return $"{GenerateStandardMessage()}\nWeather Forecast: {_weatherForecast}";
    }

}
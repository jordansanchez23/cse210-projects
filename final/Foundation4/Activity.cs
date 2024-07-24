public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;

    protected Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    public DateTime Date => _date;
    public int DurationMinutes => _durationMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({DurationMinutes} min) - " +
        $"Distance: {GetDistance()} {GetDistanceUnit()}, Speed: {GetSpeed()} {GetSpeedUnit()}, Pace: {GetPace()} min per {GetPaceUnit()}";
    }

    protected abstract string GetDistanceUnit();
    protected abstract string GetSpeedUnit();
    protected abstract string GetPaceUnit();
}
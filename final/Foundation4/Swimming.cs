public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0 * 0.62; 

    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;

    public override double GetPace() => DurationMinutes / GetDistance();

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "mile";
}
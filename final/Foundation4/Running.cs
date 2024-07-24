public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / DurationMinutes) * 60;

    public override double GetPace() => DurationMinutes / GetDistance();

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "mile";
}

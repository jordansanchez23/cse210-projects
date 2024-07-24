public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => _speed * (DurationMinutes / 60.0);

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / GetSpeed();

    protected override string GetDistanceUnit() => "miles";
    protected override string GetSpeedUnit() => "mph";
    protected override string GetPaceUnit() => "mile";
}
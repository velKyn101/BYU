public class Cycling : Activity
{
    double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling ({_duration}) - Speed: {_speed} km/h, Pace: {GetPace()} min per km";
    }
}
public class Running : Activity
{
    double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _duration) * 60;
    }

    public override double GetPace()
    {
        return _duration / _distance;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running ({_duration}) - Distance: {_distance} meters, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }


}
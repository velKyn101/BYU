public class Swimming : Activity
{
    double _laps;

    public Swimming(DateTime date, int duration, double laps) : base(date, duration)
    {
        this._laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;   
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }
    public override double GetPace()
    {
        return _duration / GetDistance();   
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} Swimming ({_duration}) - Distance: {GetDistance()} meters, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        DateTime runningDate = new DateTime(2024, 3, 11);
        Running runningActivity = new Running(runningDate, 30, 3.0);
        _activities.Add(runningActivity);

        DateTime bikeDate = new DateTime(2024, 4, 12);
        Cycling cyclingActivity = new Cycling(bikeDate, 30, 12.0);
        _activities.Add(cyclingActivity);

        DateTime swimmingDate = new DateTime(2024, 2, 15);
        Swimming swimmingActivity = new Swimming(swimmingDate, 10, 10);
        _activities.Add(swimmingActivity);

        foreach (var activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
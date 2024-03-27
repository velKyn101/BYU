class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

protected override void PerformActivity()
    {
        int totalSeconds = _duration;
        int breatheInSeconds = (int)(totalSeconds * 0.6);
        int breatheOutSeconds = totalSeconds - breatheInSeconds;

        Console.WriteLine($"Breathing in for {breatheInSeconds} seconds...");
        Thread.Sleep(breatheInSeconds * 1000);

        Console.WriteLine($"Breathing out for {breatheOutSeconds} seconds...");
        Thread.Sleep(breatheOutSeconds * 1000);
    }

    
}
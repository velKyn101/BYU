class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void PerformActivity()
    {
        int countdown = _duration;
        while (countdown > 0)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Pause for animation
            countdown--;
            if (countdown == 0) break;
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); // Pause for animation
            countdown--;
        }
    }
}
















/*
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _duration =GetDuration();

    }

    public void Run(){
        DisplayStartingMessage();
    }
}*/
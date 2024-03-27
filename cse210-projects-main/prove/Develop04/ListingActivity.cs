class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    protected override void PerformActivity()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("Get ready to list...");
        ShowCountDown(3);
        Console.WriteLine("Begin listing...");
        Thread.Sleep(_duration * 1000);

    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
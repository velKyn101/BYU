class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
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

        // Simulate user listing items
        Console.WriteLine("Begin listing...");
        Thread.Sleep(_duration * 1000);

        // Display number of items listed
        Console.WriteLine($"You listed {_count} items.");
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}











/*public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();


    public ListingActivity()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
       
    }

    public void Run()
    {
        DisplayStartingMessage();
    }

    public void GetRandomPrompts()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.Write(_prompts[index]);
    }



}




*/







/* _name = "Listing Activity";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    Console.WriteLine("How many time would you like to spend in this activity? (In seconds)");
    string duration = Console.ReadLine();
    _duration = int.Parse(duration);
*/


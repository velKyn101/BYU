using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random random;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
        "What did I learn today?",
        "Who was the most interesting person I interacted with today?",
        "Describe a challenge I faced recently.",
        "What am I grateful for?",
        "What was my goal for today and how did I accomplished it?",
        "What made me smile today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"};
        
        random = new Random();

        return _prompts[random.Next(_prompts.Count)];
    }
}
using System;

public class Program
{
    public static void Main()
    {
        Reference reference = new Reference { Book = "SampleBook", Chapter = 1, Verse = 1 };
        string scriptureText = "This is a sample scripture text for demonstration purposes";
        Scripture scripture = new Scripture(reference, scriptureText);
        
        Console.WriteLine("Welcome to the Scripture Word Hiding Program!");
        Console.WriteLine("Press Enter to hide a random number of words or type 'quit' to exit.");
        
        scripture.WaitAndHideWords();
        
        Console.WriteLine("Thank you for using the Scripture Word Hiding Program. Have a great day!");
    }
}
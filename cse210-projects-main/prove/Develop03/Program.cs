using System;
using System.IO;


public class Program
{
    static void Main(string[] args)
    {
        // Initialize a Scripture object with the reference and text
        var scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world...");

        // Display the complete scripture
        scripture.DisplayScripture(scripture);

        // Main loop to hide words until all are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide a few random words
            scripture.HideRandomWords(3); // Adjust the number of words to hide as needed

            // Display the scripture with hidden words
            scripture.DisplayScripture(scripture);
        }
    }

}
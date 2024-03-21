using System;
using System.IO;


public class Program
{
        static void Main(string[] args)
    {
        // Ask user for difficulty level
        int wordsToHide = AskForDifficulty();

        // Initialize a Scripture object with the reference and text
        var scripture = new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");

        // Display the complete scripture
        DisplayScripture(scripture);

        // Main loop to hide words until all are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide words based on difficulty level
            scripture.HideRandomWords(wordsToHide);

            // Display the scripture with hidden words
        DisplayScripture(scripture);
        }
    }
    static void DisplayScripture(Scripture scripture)
    {
        try
        {
        Console.Clear(); // This line here
        }
        catch(System.IO.IOException)
        {
            Console.WriteLine("Unable to clear console...\n");
        }
        Console.WriteLine(scripture.GetDisplayText());
    }

        static int AskForDifficulty()
    {
        while (true)
        {
            Console.WriteLine("Choose difficulty level:");
            Console.WriteLine("1. Easy (1 word hidden)");
            Console.WriteLine("2. Normal (2 words hidden)");
            Console.WriteLine("3. Hard (3 words hidden)");
            Console.Write("Enter the number corresponding to your choice: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    case 3:
                        return 3;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
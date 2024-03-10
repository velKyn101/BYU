using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Entry anEntry = new Entry();
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int userChoice;
        Console.WriteLine("Welcome to the Journal Program");
        do
        {
            Console.WriteLine("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Save \n 4. Load \n 5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                anEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                anEntry._entryText = Console.ReadLine();
                theJournal.AddEntry(anEntry);
            }
            else if (userChoice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("Write the name of the file:");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("Write the name of the file:");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }

        } while (userChoice != 5);

        Console.WriteLine("Congratulations for journaling today");
    }
}
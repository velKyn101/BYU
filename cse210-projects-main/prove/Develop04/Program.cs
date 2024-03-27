using System;
using System.Collections.Generic;
using System.Threading;


//EXCEEDING REQUIREMENTS.
//The program doesn't repeat prompts when prompting the user!!!


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Display menu
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");

            // Get user choice
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Console.Write("Enter duration in seconds: ");
                    int duration1 = int.Parse(Console.ReadLine());
                    breathingActivity.RunActivity(duration1);
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    Console.Write("Enter duration in seconds: ");
                    int duration2 = int.Parse(Console.ReadLine());
                    reflectingActivity.RunActivity(duration2);
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    Console.Write("Enter duration in seconds: ");
                    int duration3 = int.Parse(Console.ReadLine());
                    listingActivity.RunActivity(duration3);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
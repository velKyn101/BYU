using System;
using System.Collections.Generic;
using System.Threading;

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



/*
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Console.Write("Enter Duration of the program: ");
                    int duration1 = int.Parse(Console.ReadLine());
                    breathingActivity.DisplayStartingMessage();
                    break;
                
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    Console.Write("Enter Duration of the program: ");
                    int duration2 = int.Parse(Console.ReadLine());
                    reflectingActivity.DisplayStartingMessage();
                    break;
                
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    Console.Write("Enter Duration of the program: ");
                    int duration3 = int.Parse(Console.ReadLine());
                    listingActivity.DisplayStartingMessage();
                    break;
                
                case "4":
                    Environment.Exit(0);
                    break;
                
                default:
                    Console.Write("Invalid choice. Please, enter a valid choice.");
                    break;
                
            }
        }
    }
}
    
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = 0;

        do{
            Console.WriteLine("Enter a number (or type 0 to quit!):");
            
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }while (userNumber != 0);

        float sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");


        float average = sum / numbers.Count;
        Console.WriteLine($"The average is {average}"); 

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine ($"The biggest number in the list is {max}");


    }
}
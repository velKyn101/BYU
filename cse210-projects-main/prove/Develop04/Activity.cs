using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void RunActivity(int duration)
    {
        _duration = duration;
        DisplayStartingMessage();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine($"Prepare to begin. Starting in 3...");
        ShowCountDown(3);
        Console.WriteLine("Begin!");
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} activity.");
        Console.WriteLine($"Activity duration: {_duration} seconds.");
        ShowSpinner(3);
    }

    protected abstract void PerformActivity();

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
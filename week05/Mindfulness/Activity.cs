using System;
using System.Threading;

public class Activity
{
    // Private member variables for encapsulation
    private string _name;
    private string _description;
    private int _duration;

    // Public properties for controlled access
    public string Name { get { return _name; } }
    public string Description { get { return _description; } }
    public int Duration { get { return _duration; } }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} Activity...");
        Console.WriteLine(_description);
        Console.WriteLine("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Good job! You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    // Shared spinner animation method
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 5; i++)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b/");
            Thread.Sleep(200);
            Console.Write("\b-");
            Thread.Sleep(200);
            Console.Write("\b\\");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}

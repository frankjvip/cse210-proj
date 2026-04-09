using System;
using System.Collections.Generic;
using System.IO;

public class GratitudeActivity : Activity
{
    private List<string> _entries = new List<string>();
    private string _filePath = "gratitude_log.txt";

    public GratitudeActivity() 
        : base("Gratitude", "This activity helps you focus on positive aspects of your life by writing down things you are grateful for.") { }

    public void Run()
    {
        StartActivity();
        Console.WriteLine("Write down things you are grateful for. Press Enter after each one.");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
            {
                _entries.Add(entry);
            }
        }

        SaveEntries();
        Console.WriteLine("Your gratitude entries have been saved!");
        EndActivity();
    }

    private void SaveEntries()
    {
        using (StreamWriter writer = new StreamWriter(_filePath, true))
        {
            writer.WriteLine($"--- Gratitude Session ({DateTime.Now}) ---");
            foreach (string entry in _entries)
            {
                writer.WriteLine(entry);
            }
            writer.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now.ToShortDateString()
        };
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry
            {
                Date = parts[0],
                Prompt = parts[1],
                Response = parts[2]
            };
            entries.Add(entry);
        }
    }
}

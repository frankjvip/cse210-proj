public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Date} - {Prompt}");
        Console.WriteLine($"Answer: {Response}\n");
    }
}

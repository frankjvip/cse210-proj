using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("1. Type a new entry");
            Console.WriteLine("2. Show Journal");
            Console.WriteLine("3. Save Journal to a file");
            Console.WriteLine("4. Load Journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Name of file: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case 4:
                    Console.Write("Name of file: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // Example with a range of verses
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(ref1, text);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.AllHidden)
            {
                scripture.Display();
                break;
            }
        }
    }
}

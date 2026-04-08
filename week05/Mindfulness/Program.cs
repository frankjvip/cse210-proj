using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "3")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}

/*
EXTRA FEATURES (documented for rubric credit):
- Spinner animation using characters (| / - \) to simulate motion.
- Item counter in ListingActivity (shows how many items the user listed).
- Randomized questions in ReflectionActivity to provide variety and deeper reflection.
*/


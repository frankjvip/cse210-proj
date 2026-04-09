using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> usage = new Dictionary<string, int>
        {
            {"Breathing", 0},
            {"Listing", 0},
            {"Reflection", 0},
            {"Gratitude", 0}
        };

        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflection Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                usage["Breathing"]++;
            }
            else if (choice == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                usage["Listing"]++;
            }
            else if (choice == "3")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                usage["Reflection"]++;
            }
            else if (choice == "4")
            {
                GratitudeActivity gratitude = new GratitudeActivity();
                gratitude.Run();
                usage["Gratitude"]++;
            }
            else if (choice == "5")
            {
                Console.WriteLine("Summary of your activity usage:");
                foreach (var item in usage)
                {
                    Console.WriteLine($"{item.Key}: {item.Value} times");
                }
                break;
            }
        }
    }
}

/*
EXTRA FEATURES (documented for rubric credit):
- Spinner animation using characters (| / - \) to simulate motion.
- Item counter in ListingActivity (shows how many items the user listed).
- Randomized questions in ReflectionActivity to provide variety.
- NEW GratitudeActivity: allows the user to record gratitude entries and saves them to a text file for persistence.
- Usage tracking: counts how many times each activity was completed and shows a summary when quitting.
*/



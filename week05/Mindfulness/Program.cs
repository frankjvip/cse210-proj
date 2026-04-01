using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity: 1) Breathing 2) Reflection 3) Listing 4) Quit");
            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };
            if (activity == null) break;
            activity.Start();
        }
    }
}

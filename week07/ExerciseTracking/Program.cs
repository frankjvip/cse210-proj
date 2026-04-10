using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create one of each activity
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8)); // 4.8 km in 30 min
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 40, 20.0)); // 20 kph for 40 min
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 25, 30)); // 30 laps in 25 min

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

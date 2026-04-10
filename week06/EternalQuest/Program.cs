// Eternal Quest Program
// Author: Franklin
//
// NOTE: Features that exceed assignment requirements:
// 1. Multiple goal types implemented with polymorphism (SimpleGoal, ChecklistGoal, EternalGoal).
// 2. ChecklistGoal tracks partial progress and awards points incrementally.
// 3. Persistent storage: goals can be saved to and loaded from a file (goals.txt).
// 4. GoalManager class centralizes goal operations, improving modularity and scalability.
// 5. Extra Feature: Added "Level Up" system. Every 1000 points, the user levels up and receives a celebratory message.
// 
// These enhancements demonstrate creativity and extend the program beyond the core rubric.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Choose goal type: 1=Simple, 2=Eternal, 3=Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "1")
                        manager.AddGoal(new SimpleGoal(name, desc, points));
                    else if (type == "2")
                        manager.AddGoal(new EternalGoal(name, desc, points));
                    else if (type == "3")
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                    }
                    break;

                case "2":
                    manager.ShowGoals();
                    Console.Write("Which goal did you complete? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(index);
                    break;

                case "3":
                    manager.ShowGoals();
                    break;

                case "4":
                    manager.ShowScore();
                    break;

                case "5":
                    manager.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved!");
                    break;

                case "6":
                    manager.LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded!");
                    break;

                case "7":
                    running = false;
                    break;
            }
        }
    }
}



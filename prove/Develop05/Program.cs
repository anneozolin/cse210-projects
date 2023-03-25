using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int points = 0;

        Console.WriteLine($"You have 0 points\n");
        int option = 0;
        while (option != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Return");
            Console.WriteLine("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: // Create New Goal
                    int goalOption = 0;
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");   
                    Console.WriteLine("  2. Eternal Goal");   
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create ");
                    goalOption = int.Parse(Console.ReadLine());

                    switch (goalOption)
                    {
                        case 1: // Simple goal
                            var sGoal = new SimpleGoal();
                            goals.Add(sGoal);
                            Console.WriteLine($"\nYou have {0} points.\n");
                        break;

                        case 2: // Eternal goal
                            var eGoal = new EternalGoal();
                            goals.Add(eGoal);
                            Console.WriteLine($"\nYou have {0} points.\n");
                        break;

                        case 3: // Checklist goal
                            var cGoal = new ChecklistGoal();
                            goals.Add(cGoal);
                            Console.WriteLine($"\nYou have {0} points.\n");
                        break;
                        
                        default:
                        break;
                    }

                break;

                case 2: // List Goals
                    int i = 0;
                    Console.WriteLine("\nThe Goals are:");
                    foreach (Goal goal in goals)
                    {
                        i++;
                        goal.GetGoalListCheckbox(i);
                    }
                    Console.WriteLine($"\nYou have {points} points\n");
                break;

                case 3: // Save Goals
                    var saveGoal = new SaveLoad();
                    saveGoal.SaveGoal(goals, points);
                    Console.WriteLine($"\nYou have {points} points\n");
                break;

                case 4: // Load Goals
                    var loadGoal = new SaveLoad();
                    loadGoal.LoadGoal();
                    goals = loadGoal.GetGoal();
                    points = loadGoal.GetPoints();
                    Console.WriteLine($"\nYou have {points} points\n");
                break;

                case 5: // Record Event.
                    int j = 0;
                    Console.WriteLine("\nThe Goals are:");
                    foreach (Goal goal in goals)
                    {
                        j++;
                        goal.GetGoalList(j);   
                    }
                    Console.WriteLine($"Which goal did you accomplish? ");
                    int type2 = int.Parse(Console.ReadLine());

                    Goal typeGoal = goals[type2 - 1];
                    typeGoal.RecordEvent();

                    points = points + typeGoal.GetPoints();
                    Console.WriteLine($"Congratulations you have earned {typeGoal.GetPoints()} points.");
                    Console.WriteLine($"\nYou have {points} points");
                    Console.WriteLine();
                break;  

                default: // Quit program.
                    Console.Clear();
                break;
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        SimpleGoal Sgoal = new SimpleGoal();
        EternalGoal EGoal = new EternalGoal();
        ChecklistGoal CGoal = new ChecklistGoal();
        List<Goal> goals = new List<Goal>();
        while (opcion !=6)
        {
                Console.WriteLine("Menu options:\n"+
                "\n1.Create a new goal"+
                "\n2.List goals"+
                "\n3.Save goals"+
                "\n4.Load Goals"+
                "\n5.Record Events"+
                "\n6.Quit");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion){

                            case 1: // Create New Goal
                            int answer = 0;
                             Console.WriteLine(" Wich type of goal would you like to create? \n"+
                                "\n1.Simple Goal"+
                                "\n2.Eternal Goal"+
                                "\n3.Checklist Goal");
                                answer = int.Parse(Console.ReadLine());
                                switch(answer)
                                {
                                    case 1: // Simple goal 
                                    Sgoal.GetGoal();
                                    goals.Add(Sgoal);
                                        break;

                                    case 2: // Eternal Goal
                                    EGoal.GetGoal();
                                    goals.Add(EGoal);
                                        break;

                                    case 3: //Checklist Goal
                                    CGoal.GetGoal();
                                    goals.Add(CGoal);
                                        break;

                                    default:
                                        Console.Write("Please enter a valid choice:\n");
                                        break;
                                }

                                break;
                            case 2: // List goals
                            int i = 0;
                            Console.WriteLine("\nThe Goals are:");
                            foreach (Goal goal in goals)
                            {
                                i++;
                                goal.PrintGoal();
                            }
                            //Console.WriteLine($"\nYou have {_points} points\n");
                
                          

                                break;
                            case 3: //Save goals
                                Console.WriteLine("Enter a file Name with a file extension (txt)");
                                    string fileName =  Console.ReadLine();

                                    using (StreamWriter outputFile = new StreamWriter(fileName))
                                    {
                                    foreach(Goal x in goals)
                                    {
                                        
                                        outputFile.WriteLine(x.SaveFile());
                                    }
                                    }
                                break;
                            case 4: // Load Goals
                             {

                             }
                                break;
                            case 5: // Record Events
                                Console.WriteLine("The goals are:");
                              foreach (Goal i in goals)
                            {
                                i.Record();
                            }
                                Console.WriteLine(" Wich goal did you acomplish?");
                                Sgoal.RecordEvent();
                                EGoal.RecordEvent();
                                CGoal.RecordEvent();
                                break;
                            case 6:
                                Console.WriteLine("Goodbye");
                                break;
                            default:
                                Console.Write("Please enter a valid choice:\n");
                                break;

                    }
        }
    }
}
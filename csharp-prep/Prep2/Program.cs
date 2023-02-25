using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine(" ");

        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);

        string gradeLetter = "";

        if (gradePercentage >= 90) 
            {
                gradeLetter = "A";
            }
        else if (gradePercentage >= 80)
            {
                gradeLetter = "B";
            }
        else if (gradePercentage >= 70)
            {
                gradeLetter = "C";
            }
        else if (gradePercentage >= 60)
            {
                gradeLetter = "D";
            }
        else
            {
                gradeLetter = "F";
            }
        
        Console.WriteLine($"Your grade is: {gradeLetter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}
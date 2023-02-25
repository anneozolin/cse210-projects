using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine(" ");

        Console.WriteLine("What is your first name?");
        string fistName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine(" ");

        Console.WriteLine($"Your name is {lastName}, {fistName} {lastName}.");
    }

}
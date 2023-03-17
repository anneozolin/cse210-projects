using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity Breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity Reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
        ListingActivity Listing = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int userOption = 0;

        while (userOption !=4)
        {
            Console.WriteLine("Menu Options:\n");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start reflecting activity");
            Console.WriteLine("3.Start listing activity");
            Console.WriteLine("4.Quit");
            Console.Write("\nSelect a choice from the menu :");

            userOption = int.Parse(Console.ReadLine());
            
            switch(userOption){
                case 1:
                Breathing.DisplayStartMessege();
                Breathing.BreathingSteps();
                Breathing.DisplayEndMessege();
                break;
                
                case 2:
                Reflecting.DisplayStartMessege();
                Reflecting.ReflectingSteps();
                break;
                
                case 3:
                Listing.DisplayStartMessege();
                Listing.ListingComplete();
                break;
                
                case 4:
                Console.WriteLine("\nGoodbye");
                break;
                
                default:
                Console.Write("Please enter a valid choice:\n");
                break;
            }
        }
    }
}
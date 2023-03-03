using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the your Journal!");

        int menuUserInput = 0;

        Journal journal = new Journal();
        

        List<string> menu = new List<string>
            {
                "Please enter a number:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "Your number: "
            };

        while (menuUserInput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());

            switch(menuUserInput) {
                case 1:
                    journal.CreateJournalEntry();
                    break;
                case 2:
                    journal.DisplayJournalEntries();
                    break;
                case 3:
                    journal.LoadFromTXT(); 
                    break;
                case 4:
                    journal.SaveToTXT();
                    break;
                case 5:
                    Console.WriteLine("See you tomorrow!");
                    break;
                default:
                    Console.Write("Please choose a valid number:\n");
                    break;
            }
        }

    }
}

        //if (menuUserInput == 1)
        //{
            //journal.CreateJournalEntry();
        //}
        //else if (menuUserInput == 2)
        //{
            //journal.DisplayJournalEntries();
        //}
        //else if (menuUserInput == 3)
        //{
            //journal.LoadFromTXT(); 
        //}
         //else if (menuUserInput == 4)
        //{
            //journal.SaveToTXT();
        //}
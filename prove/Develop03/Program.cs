using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!\n");

        // create a new scripture
        Scripture scripture = new Scripture("John 3:16-17", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God did not send his Son into the world to condemn the world, but to save the world through him.");

        // clear the console screen and display the scripture
        Console.Clear();
        Console.WriteLine(scripture);

        while (true)
        {
            // prompt the user to press enter or quit
            Console.WriteLine("\nPress enter to hide some words or type 'quit' to exit...");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                // exit the program if the user types 'quit'
                break;
            }
            else
            {
                // hide some random words and display the scripture again
                scripture.HideRandomWords();
                Console.Clear();
                Console.WriteLine(scripture);

                if (scripture.AllWordsHidden)
                {
                    // exit the program if all words have been hidden
                    break;
                }
            }
        }
    }
}
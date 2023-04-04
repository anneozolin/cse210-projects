using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "12345");

        Lecture lecture = new Lecture("AI for Everyone", "Learn about AI and its applications", "15/04/2023", "10:00", address, "Maria Smith", 50);
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Reception reception = new Reception("Garden Party", "Join us for an elegant garden party, complete with beautiful flowers.", "15/05/2023", "19:00", address, "rsvp@eventplanningco.com");
        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Enjoy a day in the sun with friends and family", "21/06/2023", "12:00", address, "Rain or shine!");
        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());

    }
}
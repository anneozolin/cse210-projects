using System;
using System.IO;


class Journal
{
    public List <Entry> _entries = new List<Entry>();

    public string _userFileName;
    public List<string> _journalEntries = new List<string>();

    public void CreateJournalEntry()
    {
        Entry newEntry = new Entry();
        newEntry.AddEntry();
        _entries.Add(newEntry);
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date} {entry._prompt} {entry._answer}");
        }
    }

    public void SaveToTXT()
    {
        Console.WriteLine("Enter a file name (.txt)");
        string fileName =  Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} -{entry._prompt} -{entry._answer}");
            }
        }
        }

    public void LoadFromTXT()
    {
        Console.WriteLine("What file's name would you like to load");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";
        string[] journalLines = File.ReadAllLines(_userFileName);


        foreach (string line in journalLines)
        {  
            Console.WriteLine(line);
        }
    }
}
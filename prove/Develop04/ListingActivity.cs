

public class ListingActivity : Activity
{
    public ListingActivity(string activity, string description) : base (activity, description)
    {

    }

    protected int _answers = 0;

    protected List<string> _prompts = new List<string>
    {
     "Who are people that you appreciate?",
     "What are personal strengths of yours?.",
     "Who are people that you have helped this week?",
     "When have you felt the Holy Ghost this month?",
     "Who are some of your personal heroes?"
    };

    public string GetRandomPrompt()
    {
        Random Prompt = new Random();
        int i = Prompt.Next(_prompts.Count);
        string prompt = _prompts[i];
        Console.WriteLine($"{prompt}");
        return prompt;
    }
    public void ListingComplete()
    {
        Console.WriteLine("\nList as many responses you can to the following propmt");
        GetRandomPrompt();
        Console.WriteLine("\nYou may begin in:");
        PausingTimer(5);
        while(DateTime.Now < _endTime)
        {
            Console.ReadLine();
            _answers ++;
         }
         Console.WriteLine($"\nYou list {_answers} items.");
         DisplayEndMessege();
           

    }
    
}
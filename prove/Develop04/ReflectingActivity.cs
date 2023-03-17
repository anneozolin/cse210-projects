

public class ReflectingActivity : Activity
{
    public ReflectingActivity(string activity, string description) : base (activity, description)
    {

    }
    protected List<string> _RandomPrompts = new List<string>
    {
     "Think of a time when you stood up for someone else.",
     "Think of a time when you did something really difficult.",
     "Think of a time when you helped someone in need.",
     "Think of a time when you did something truly selfless."
    };

    protected List<string> _RandomQuestions = new List<string>
    {
     "How did it feel when it was complete.?",
     "What is you favourite thing about this experience?",
     "What is something you does not like about this experience?",
     "How could you face something similar now?"
    };

    public string GetRandomPrompt()
    {
        Random Prompt = new Random();
        int i = Prompt.Next(_RandomPrompts.Count);
        string prompt = _RandomPrompts[i];
        Console.WriteLine($"{prompt}");
        return prompt;
    }

    public string GetRandomQuestion()
    {
         Random Prompt = new Random();
        int i = Prompt.Next(_RandomQuestions.Count);
        string question = _RandomQuestions[i];
        Console.WriteLine($"{question}");
        return question;
    }

    public void ReflectingSteps()
    {
        Console.WriteLine("\nConsider the following prompt:");
        GetRandomPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they realated to this experience.");
        Console.WriteLine("You may begin in:");
        PausingTimer(3);

        while(DateTime.Now < _endTime)
        {
            GetRandomQuestion();

            if (DateTime.Now <_endTime)
            {
                PausingTimer(5);
                GetRandomQuestion();

                PausingTimer(5);
                GetRandomQuestion();
            }
        }
        DisplayEndMessege();
    }


}
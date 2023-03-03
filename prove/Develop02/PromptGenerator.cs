using System;

class PromptGenerator
{
    List<string> _prompts = new List<string>() { 
        "Who was the most interesting person you interacted with today?", 
        "What was the best part of your day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?" };
    

    public string GetRandomPrompt()
    {
        Random Prompt = new Random();
        int i = Prompt.Next(_prompts.Count);
        string question = _prompts[i];
        Console.WriteLine($"{question}");
        return question;
    }

}
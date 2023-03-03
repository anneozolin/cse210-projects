using System;

class PromptGenerator
{
    List<string> _prompts = new List<string>() { 
        "Did you spend time with anyone special today?", 
        "What was the most interesting thing that happened to you today?", 
        "What did you do first thing in the morning?", 
        "Did you learn anything new today?",
        "Did you encounter any challenges today?",
        "Did you feel happy or satisfied with your day overall?",
        "What time did you wake up this morning?",
        "Did you do anything fun or exciting today?",
        "Did you exercise or participate in any physical activity today?",
        "What was the most challenging task you had to accomplish today?",
        "Did you have any interesting conversations with friends, family, or coworkers today?",
        "What did you eat for breakfast, lunch, and dinner today?",
        "Did you have any downtime or leisure time today? If so, what did you do?",
        "What is something positive that happened to you today?",
        "Did you accomplish anything significant today?" };
    

    public string GetRandomPrompt()
    {
        Random Prompt = new Random();
        int i = Prompt.Next(_prompts.Count);
        string question = _prompts[i];
        Console.WriteLine($"{question}");
        return question;
    }

}
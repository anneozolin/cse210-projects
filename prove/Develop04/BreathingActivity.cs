

public class BreathingActivity : Activity
{
    public BreathingActivity(string activity, string description) : base (activity, description)
    {

    }

    public void DisplayBreathIn()
    {
        Console.WriteLine("\nBreath in...");
        PausingTimer(3);
    }

    public void DisplayBreathOut()
    {
        Console.WriteLine("\nBreath out...");
        PausingTimer(6);
    }

    public void BreathingSteps()
    {
        while(DateTime.Now < _endTime)
        {
            DisplayBreathIn();
            if (DateTime.Now <_endTime)
            {
                DisplayBreathOut();
            }
        }
    }
}
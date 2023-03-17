
public class Activity
{
    protected int _duration;
    protected string _activity;
    protected string _description;

    protected DateTime _endTime;


    public Activity (string activity, string description)
    {
        _activity = activity;
        _description = description;
    }

    public void GetActivityDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartMessege()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activity}.");
        Console.WriteLine(_description);

        GetActivityDuration();
        
        Console.WriteLine("Get ready...");

        PausingSpinner(4);

        DateTime startTime = DateTime.Now;
        _endTime = startTime.AddSeconds(_duration);
    }

    public void DisplayEndMessege()
    {
        Console.WriteLine("\nWell Done!");
        PausingSpinner(3);
        Console.WriteLine($"You have completed another {_duration} of the {_activity} Activity");
        PausingSpinner(5);
        Console.Clear();
    }

    public void PausingSpinner(int _duration)
    {
        List <string> AnimationString = new List<string> ()
        {
            "|" ,"/","-","\\"

        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = AnimationString [i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i>=AnimationString.Count)
            {
                i = 0;
            }
        }

    }
    
    public void PausingTimer(int number)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(number);

        while (DateTime.Now <endTime && number>0)
        {

            Console.Write(number);
            Thread.Sleep(1000);
            if(number.ToString().Length == 1 )
            {
                Console.Write("\b \b");
            }
            else
            {
                Console.Write("\b \b\b \b");
            }
           

            number--;
        
        }
    }

}
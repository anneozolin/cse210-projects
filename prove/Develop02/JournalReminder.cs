using System;
using System.Timers;

class JournalReminder
{
    private System.Timers.Timer _timer = new System.Timers.Timer();

    public JournalReminder()
    {
        _timer = new System.Timers.Timer();
        _timer.Interval = 600000; // 10 minutes in milliseconds
        //_timer.Interval = 60000; // 1 minute in milliseconds
        _timer.Elapsed += Timer_Elapsed;
        _timer.AutoReset = false;
        _timer.Enabled = true;
    }

    public void Start()
    {
        Console.WriteLine("You will be reminded to write in your journal in 10 minutes.");
    }

    public void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine("Don't forget to write in your journal!");
    }
}

using static System.Console;
using System.IO;

public class EternalGoal : Goal
{
    public EternalGoal() 
    : base()
    {
        base._completed = false;
    }
    
    public EternalGoal(string name, string description)
    : base(name, description)
    {
    }
    public override void RecordEvent()
    {
    }

    public override string SaveGoal() 
    {
        return $"Eternal Goal:{base._name},{base._description},{base._points}";
    }
}

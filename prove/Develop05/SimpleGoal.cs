using static System.Console;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
    }

    public SimpleGoal(string name, string description) : base(name, description)
    {

    }

    public override void RecordEvent()
    {
        base._completed = true;
    }

    public override void GetGoalListCheckbox(int number)
    {
        string checkbox = "";
        if (base._completed)
        checkbox = "X";
        WriteLine($"{number}. [{checkbox}] {base._name} ({base._description})");
    }

    public override string SaveGoal() 
    {
        return $"Simple Goal:{base._name},{base._description},{base._points},{base.IsComplete()}";
    }
}
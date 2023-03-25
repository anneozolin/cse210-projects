using static System.Console;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal() 
    : base()
    {
    }

    public SimpleGoal(string name, string description)
    : base(name, description)
    {

    }

    public override void RecordEvent()
    {
        base._completed = true;
    }

    public override void GetGoalList1(int number)
    {
        string mark_X = "";
        if (base._completed)
        mark_X = "X";
        WriteLine($"{number}. [{mark_X}] {base._name} ({base._description})");
    }

    public override string SaveGoal() 
    {
        return $"Simple Goal:{base._name},{base._description},{base._points},{base.IsComplete()}";
    }
}
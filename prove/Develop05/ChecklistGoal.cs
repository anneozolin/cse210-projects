using static System.Console;
using System.IO;

public class ChecklistGoal : Goal
{
    private int _target = 0;
    protected int _times = 0;
    protected int _bonus = 0;
    
    public ChecklistGoal() 
    : base()
    {
        Write("How many times does this goal need to be accomplished for a bonus? ");
        _target = int.Parse(ReadLine());
        Write("What is the bonus for accomplishing that many times? ");
        _bonus = int.Parse(ReadLine());
    }

    public ChecklistGoal(string name, string description, int target, int times)
    : base(name, description)
    {

    }

    public override void GetGoalList1(int number) 
    {
        string mark_X = "";
        if (base._completed)
        mark_X = "X";
        WriteLine ($"{number}. [{mark_X}] {base._name} ({base._description}) --- Currently completed {this._times}/{this._target}");
    }

    public override void RecordEvent() 
    {
        this._times++;
        if (this._times == this._target)
        base._completed = true;
    }

    public override string SaveGoal() 
    {
        return $"Checklist Goal:{base._name},{base._description},{base._points},{this._bonus},{this._times},{this._target}";
    }
}
using static System.Console;
using System.IO;

public abstract class Goal
{
    
    
    protected string _name;
    protected string _description;
    protected int _points = 0;
    protected bool _completed = false;

    public Goal()
    {
         Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal");
        _points = int.Parse(Console.ReadLine());
    }

    public Goal(string name, string description, int points)
    {
    }

    public Goal(string name, string description)
    {
    }
    public int GetPoints()
    {
        return this._points;
    }

    public virtual void RecordEvent()
    {
        this._completed = true;
    }

    public virtual bool IsComplete()
    {
        return this._completed = true;
    }

    public virtual void GetGoalList1(int number)
    {
        WriteLine($"{number}. [ ] {this._name} ({this._description})"); 
    }
    public virtual void GetGoalList2(int number)
    {
        WriteLine($"{number}. {this._name}"); 
    }
    public virtual string SaveGoal() 
    {
        return $"{_name},{_description},{_points},{_completed}";
    }
}
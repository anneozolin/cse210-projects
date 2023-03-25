public class Goal
{
    protected string _name;

    protected string _description;

    protected int _points;

    protected int _totalPoints;

    protected bool _check;

    protected int _answer;

      public virtual void GetGoal()
    {
         Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal");
        _points = int.Parse(Console.ReadLine());
        
    }

    public  virtual void PrintGoal()
    {
           if (_check == false)
        {
            Console.Write("[]");
        }
        else
        {
            Console.Write("[x]");
            
        }
        Console.WriteLine ($"{_check } {_name} ({_description}) ");

    }

    public void GetTotalPoints()
    {
        Console.WriteLine($"You have {_totalPoints}");
    }


    public virtual void Record()
    {
        Console.WriteLine($"{_name}");
    }


     public virtual void RecordEvent()
    {
        _answer = int.Parse(Console.ReadLine());
        if (_answer == 1)
        {   
            _check = true;
            _totalPoints += _points;
            Console.WriteLine($"Congratulations you earned {_points} points");


        }
    }


    public virtual void LoadFile()
    {

    }

    public virtual string SaveFile()
    {
        
        return $"{_name} {_description} {_points} ";
    }


    public virtual bool Iscomplete()
    {
        return true;
    }

}
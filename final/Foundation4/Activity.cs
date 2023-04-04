public class Activity
{
    private DateTime _date;
    public int _length;

    public Activity(DateTime date, int length)
    {
        this._date = date;
        this._length = length;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string unit = "km";
        if (this is Running) unit = "mi";

        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_length} min) - Distance: {distance:F1} {unit}, Speed: {speed:F1} {unit}/h, Pace: {pace:F1} min/{unit}";
    }
}
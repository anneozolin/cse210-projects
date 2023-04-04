public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60 / 1.609;
    }

    public override double GetPace()
    {
        return _length / _distance / 1.609 * 60;
    }
}
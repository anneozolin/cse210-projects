public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60 / 1.609;
    }

    public override double GetPace()
    {
        return _length / GetDistance() / 1.609 * 60;
    }
}
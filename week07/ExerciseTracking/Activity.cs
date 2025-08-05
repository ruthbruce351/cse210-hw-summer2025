public abstract class Activity
{
    protected string _name;
    protected DateTime _date;
    protected int _minutes;

    public Activity(string name, DateTime date, int minutes)
    {
        _name = name;
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {_name} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}
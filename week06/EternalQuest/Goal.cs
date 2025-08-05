public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    { }

    public bool IsComplete()
    { }

    public string GetDetailsString()
    {
        
    }

    public string GetStringRepresentation()
    {

    }
}
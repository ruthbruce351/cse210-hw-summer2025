public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
    }
    
    public override string GetDetailsString()
    {
        return $"Simple|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
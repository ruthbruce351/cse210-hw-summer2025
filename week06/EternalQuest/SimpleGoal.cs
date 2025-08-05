public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points, bool isComplete = false)
        : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            _lastEventPoints = _points;
        }
        else
        {
            _lastEventPoints = 0;
        }
    }
    

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
    }
    
    public override string GetStringRepresentation()
    {
        return $"Simple|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
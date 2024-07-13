public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false; 
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return _isComplete; 
    }

    public void SetCompletionStatus(bool status)
    {
        _isComplete = status; 
    }

    public override string GetDetailsString()
    {
        return $"[ {(_isComplete ? "X" : " ")} ] {_shortName}: {_description}, Points: {_points}";
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
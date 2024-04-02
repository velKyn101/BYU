public class SimpleGoal : Goal
{

    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
        public override string GetDetailsString()
    {
        return $"{_name}, {_description}, {_points}, {_isComplete}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_name}, {_description}, {_points}, {_isComplete}";
    }

}
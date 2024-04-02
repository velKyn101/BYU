public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are never completed
    }
        public override string GetDetailsString()
    {
        return $"{_name}, {_description}, {_points}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_name}, {_description}, {_points}, Eternal";
    }
    
}
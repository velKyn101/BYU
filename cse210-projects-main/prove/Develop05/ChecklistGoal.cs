using System.ComponentModel;

public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;    
        }
        else
        {
            return false;
        }
        
    }
    public override string GetDetailsString()
    {
        return $"{_name}, {_description}, {_points}, {_amountCompleted}/{_target} times";
    }
        public override string GetStringRepresentation()
    {
        return $"{_name}, {_description}, {_points}, {_amountCompleted}/{_target} times, {_bonus}";
    }
}
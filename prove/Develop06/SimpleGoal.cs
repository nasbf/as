using System;


public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override bool Iscompleted()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simplegoal,{_nameGoal}, {_description}, {_points}, {_iscompleted}";
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
}
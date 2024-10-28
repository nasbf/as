using System;


public class EternalGoal : Goal
{
    public EternalGoal (string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override bool Iscompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal goal: {_nameGoal}, {_description}, {_points}";
    }

}
using System;


public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    
    public ChecklistGoal (string name, string description, int points, int target, int bonus): base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    // public int GetAmountCompleted()
    // {
    //     _amountCompleted++
    //     return _amountCompleted;

    //     if (_amountCompleted == _target)
    //     {
    //         Console.WriteLine($"Excellent  you have complete {_nameGoal}");
    //     }
    // }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }   
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }   
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }   
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Excellent  you have complete {_nameGoal}");
                return _points + _bonus;
            }
            else
            {
                return _points;
            }
            return 0;
        }
    }

    public override bool Iscompleted()
    {
        if (_amountCompleted >= _target)
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
        return $"[ ] {_nameGoal}: {_description}, completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist: {_nameGoal}, {_description}, {_points}, {_amountCompleted}, {_target},{_bonus}";
    }
}
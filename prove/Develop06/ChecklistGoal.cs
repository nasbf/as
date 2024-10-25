using System;


public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    
    public ChecklistGoal (string name, string description, int points, int target, int bonus)
    {
        
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
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



public void RecordEvent()
    {

    }

    public bool Iscompleted()
    {

    }
    public string GetDetailsString()
    {

    }
    public string GetStringRepresentation()
    {

    }
}
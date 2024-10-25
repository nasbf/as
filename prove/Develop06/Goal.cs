using System;


public abstract class Goal
{
    private string _nameGoal;
    private string _description;
    private int _points = 0;
    public string GetName()
    {
        return _nameGoal;
    }
    public void SetName(string name)
    {
        _nameGoal = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
public string GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public Goal (string name, string description, int points)
    {
        _nameGoal = name;
        _description = description;
        _points = points;
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
using System;


public class Mathassignment: Assignment

{
    private string _textBookSection;
    private string _problems;

    public void SettextBookSection(string section)
    {
        _textBookSection = section;
    }

    public string GetTextBookSection()
    {
        return _textBookSection;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetProblems ()
    {
        return _problems;
    }

    public string GetHomeWork()
    {
        return $"{_textBookSection}, {_problems}";
    }
}
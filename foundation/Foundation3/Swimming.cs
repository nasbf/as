using System;


public class Swimming : Activity
{
    private int _laps;
    public Swimming (DateTime date, int time, int laps): base (date, time)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
    public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public override int GetDistance ()
    {
        return (_laps * 50 /1000);
    }
    public override int GetSpeed ()
    {
        return (GetDistance() / _time) * 60;

    }

    public override double Getpace ()
    {
       return _time / (GetDistance());
    }
}
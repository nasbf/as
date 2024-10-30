using System;


public class Cicling : Activity
{
    private int _speed;
    public Cicling (DateTime date, int time, int speed): base (date, time)
    {
        _speed = speed;
    }
    public override int GetSpeed ()
    {
        return _speed;
    }

    public override int GetDistance ()
    {
        return _speed * (_time / 60);
    }

    public override double Getpace ()
    {
        return _speed / 60;
    }



}
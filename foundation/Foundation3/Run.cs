using System;


public class Run : Activity
{
    private int _distance;

    public Run (DateTime date, int time, int distance): base (date, time)
    {
        _distance = distance;
    }

    public override int GetDistance ()
    {
        return _distance;
    }
    public override int GetSpeed ()
    {
        return _distance / _time * 60;

    }

    public override double Getpace ()
    {
       return _time / _distance;
    }

    // public override void GetSumary()
    // {
    //     Console.WriteLine $"{_date}, Running, tiempo {_time}, distancia{GetDistance()}, Velocidad {GetSpeed()}, {Getpace()}} "
    // }
}
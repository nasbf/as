using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime _date;
    protected int _time;

    public Activity (DateTime date, int time)
    {
        _date = date;
        _time = time;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public DateTime GetDate()
    {
        return _date;
    }
   
   public void SetTime(int time)
    {
        _time = time;
    }

    public int GetTime()
    {
        return _time;
    }
   

    public abstract int GetDistance ();
    
    public abstract int GetSpeed ();
   
    public abstract double Getpace ();
    
    public void GetSumary ()
    {
        Console.WriteLine ($"{_date:yyyy/MMMM/dd}, tiempo:{_time}, Distance:{GetDistance()}, Speed:{GetSpeed()}, Pace:{Getpace()}");
    }
    
    
    

}
using System;

public class Commun
{
    protected string _nameActivity;
    protected string _description;
    protected int _time;
    private List<string> animationsStrings = new List<string> 
    {
        "|", "/", "-","\\","|"
    };
    
    public string GetNameActivity ()
    {
        return _nameActivity;
    }
    public void SetNameActivity(string activity)
    {
        _nameActivity = activity;
    }
    public string GetDescription ()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetTime ()
    {
        return _time;
    }
    public void SetTime (int time)
    {
        _time = time;
    }
    //int time = 0;
    public void DisplayFirstMessage ()
    {
        Console.WriteLine(_nameActivity);
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session?:  ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner (3);
    }
    
    public void DisplayEndMessage ()
    {
        Console.WriteLine("Well Done");
        Console.WriteLine($"You have complete {_time} seconds of the {_nameActivity}");
        ShowSpinner (3);
    }


    public void ShowSpinner (int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationsStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            
            if (i >= animationsStrings.Count)
            {
                i = 0; 
            }
        }
 
    }

    public void ShowCount (int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
        //DisplayEndMessage();
    }

}
using System;

public class Breath : Commun
{
    public Breath()
    {
        _nameActivity = "Breating";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void run ()
    {
        DisplayFirstMessage ();
        
        while (_time > 0)
        {
            Console.WriteLine("Breathe in ...");
            for (int i = 5; i> 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("Breathe out ...");
            for (int i = 5; i> 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            _time -= 10;
        }
        
      
        DisplayEndMessage();
    }
        
        
    
}
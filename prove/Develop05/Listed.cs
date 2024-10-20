using System;
using System.Collections.Generic;

public class Listed : Commun
{
    private int _count;
    private List<string> _answers = new List<string>();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listed ()
    {
        _nameActivity = "List";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
    }

    public void Run ()
    {
        DisplayFirstMessage ();
        DisplayPrompt();
        GetListed();
        DisplayEndMessage();

    }

    public string GetRandomPrompt()
    {

        Random random = new Random();
        int aleatoryX = random.Next (0, _prompts.Count);
        return (_prompts[aleatoryX]);   
    }


    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("you may begin in: ");
        ShowCount (5);
    }
    public void GetListed ()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            _answers.Add(response);
            _count++;
            
        }
        
       Console.WriteLine($"You listed {_count} items. ");
    }
}

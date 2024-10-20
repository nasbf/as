using System;
using System.Collections.Generic;

public class Reflect : Commun
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public Reflect ()
    {
        _nameActivity = "Reflect";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Run()
    {
        DisplayFirstMessage ();
        DisplayPrompt();
        DisplayQuestion();
        DisplayEndMessage();

    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("When You Have Something in mind press enter to continue. ");
        Console.ReadLine();
    }
    public void DisplayQuestion()
    {

        Console.WriteLine("Now ponder on each of following questions");
        Console.WriteLine("You might begin in:");
        ShowCount (3);
        
        while (_time > 0)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
            _time -= 5;

            if (_time <= 0)
            {
                break;
            }

        }

    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int aleatoryX = random.Next (0, _prompts.Count);
        return (_prompts[aleatoryX]);  

    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int aleatoryX = random.Next (0, _questions.Count);
        return (_questions[aleatoryX]);

    }
    
        
 
        




}
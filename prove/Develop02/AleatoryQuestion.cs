using System;
using System.Collections.Generic;

public class AleatoryQuestion
{
    public List<string> _questions;

    public AleatoryQuestion()
    {
        _questions = new List<string>

        {
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? "
        };
    }

        
        public string GetRandomPrompt()
        {
        
            Random random = new Random();
            int aleatoryX = random.Next (0, _questions.Count);
            return (_questions[aleatoryX]);
            
        }

        
}
    


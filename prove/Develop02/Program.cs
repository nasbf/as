using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal1 = new Journal ();

        bool active = true;
        while (active)
        {
            Console.WriteLine("Welcome to the Journal program ");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What do you like to do? ");
            Console.WriteLine();
            string choice = Console.ReadLine ();
            int userChoice = int.Parse(choice);

            
            switch (userChoice)
            {
                case 1:
                    AleatoryQuestion aleatoryQuestion = new AleatoryQuestion();
                    string prompt = aleatoryQuestion.GetRandomPrompt();
                    
                    Console.WriteLine(prompt);
                    
                    string entryText = Console.ReadLine();
                    DateTime CurrentTime = DateTime.Now;
                    string date = CurrentTime.ToShortDateString();                
                    Console.WriteLine();
                    Jentry newEntry = new Jentry (date, prompt, entryText);
                    
                    journal1.AddEntry (newEntry);

                    break;

                case 2:
                    
                    journal1.DisplayAll();
                    break;
                case 3:
                    
                    Console.Write("What's the file name?");
                    string userFileName = Console.ReadLine ();
                    journal1.LoadToFile(userFileName);
                    break;

                case 4:
                    Console.Write("What's the file name?");
                    string fileName = Console.ReadLine();
                    journal1.SaveToFile(fileName);
                    break;
                
                case 5:
                    
                    active = false;
                    Console.WriteLine("You chose to quite. Thanks");
                    break;

            }
        }
        
            

    }

}

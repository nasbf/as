using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        bool active = true;
        while (active)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");        
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Breath breath1 = new Breath();
                    breath1.run();
                    break;
            
                case "2":
                    Reflect reflect1 = new Reflect();
                    reflect1.Run();
                    break;
            
                case "3":
                    Listed listed1 = new Listed();
                    listed1.Run();
                    break;
            
                case "4":
                    active = false;
                    Console.WriteLine("You chose to quit. be positive you are a child of God.");
                    break;
            }
        }

    }
}
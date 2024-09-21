using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number?  ");
        //string number = Console.ReadLine();
        string answer;
        do
        {
            Console.WriteLine("Welcome you have to guess a number between 1 to 50");
            Random randomGenerator = new Random();
            int mNumber =  randomGenerator.Next (1,51);
        
            int gNumber; 
        
       
            do
            {
                Console.WriteLine("What is your guess?  ");
                string guess = Console.ReadLine();
                gNumber = int.Parse(guess);

               

                if (gNumber == mNumber)
                {
                    Console.WriteLine($"Is correct the magic number is {mNumber}");
                }
                else if (gNumber > mNumber)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("Higher");
                }
            }while (gNumber != mNumber);
        
        Console.WriteLine("Do you whant to play again?  ");
        answer = Console.ReadLine();

        }while (answer == "yes");
        
        
        
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage ();
        string name = PromptUserName ();
        int number = PromptUserNumber ();
        double x = SquareNumber (number);

                Console.WriteLine($"{name}, the square of your number is {x}");
        


        static void DisplayMessage()
        {
           Console.WriteLine("Welcome to the program");
        }
        
        static string PromptUserName()
        {  
            Console.WriteLine("Please enter your name:  ");
            string userName = Console.ReadLine();
            return (userName);
        }   
        static int PromptUserNumber()
            {  
                Console.WriteLine("Please enter your number:  ");
                int userNumber = int.Parse(Console.ReadLine());
                return userNumber;
            }   
        static double SquareNumber(int number)
            {
                double x = Math.Pow(number, 2);
                return x;
            }
        

    }
}
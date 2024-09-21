using System;

class Program
{
    static void Main(string[] args)
    {
        /* primero se llama el metodo no al final. 
        cuando creo el metodo identifico si es string o int o void(mix), 
        para llamar el metodo si necesito el resultado debo crear la variable por ejemplo, cree la variable name y su 
        resultado es lo que regresa el metodo PromptUserName.
        Los argumentos son las variable que he creado fuera del metodo en este caso (name y x) los uso en el metodo 
        DisplayResult.  */


        DisplayMessage ();
        string name = PromptUserName ();
        int number = PromptUserNumber ();
        double x = SquareNumber (number);
        DisplayResult (name, x);

        
        


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
        
        static void DisplayResult(string name, double x)
            {
                Console.WriteLine($"{name}, the square of your number is {x}");
            }


    }
}
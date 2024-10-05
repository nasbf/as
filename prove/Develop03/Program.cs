using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("3Nefi", 12, 48);
        
        string scriptureText = "sed perfectos asi como yo, o como vuestro Padre que esta en los cielos es perfecto";

        Scripture scripture = new Scripture (reference, scriptureText);

        while (true)
        {
            
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Type Enter to hidde the words or write 'quit' to end the program:");
            string input = Console.ReadLine();

            
            if (input.ToLower() == "quit")
            {
                break;  
            }

            
            if (string.IsNullOrEmpty(input))
            {
                
                scripture.HideRandomWords(2); 
            }

            
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                break;
            }
        }
    }
}
            

        





        
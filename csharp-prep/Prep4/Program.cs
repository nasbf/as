using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        List<int> numbers = new List<int>();
        

        int uNumber;

        do
        {
            
            Console.WriteLine("Enter number:  ");
            string userNumber = Console.ReadLine();
            uNumber = int.Parse(userNumber);

           
            numbers.Add(uNumber);

            
        }while (uNumber != 0);

        //foreach (int num in numbers)
        //{
        //    Console.WriteLine(num);
        //}
        float adittion = 0;
        int major = numbers[0];
        
        foreach (int num in numbers)
        {
            adittion += num;
            if (num > major)
            {
                major = num;
            }
            
            
        }
        Console.WriteLine($"the sum is: {adittion}");
        Console.WriteLine($"the largest number is: {major}");
        
        float items = (numbers.Count);
        
        float promedio = adittion/items;
        Console.WriteLine($"The average is: {promedio}");


    }   


}
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction result = new Fraction ();
        Console.WriteLine(result.GetFractionString ());
        Console.WriteLine(result.GetDecimal ());
        Console.WriteLine();

        Fraction result1 = new Fraction (8);
        Console.WriteLine(result1.GetFractionString ());
        Console.WriteLine(result1.GetDecimal ());
        Console.WriteLine();
        
        Fraction result2 = new Fraction (5,3);
        Console.WriteLine(result2.GetFractionString ());
        Console.WriteLine(result2.GetDecimal ());
        Console.WriteLine();
        
        Fraction result3 = new Fraction (6,2);
        Console.WriteLine(result3.GetFractionString ());
        Console.WriteLine(result3.GetDecimal ());
        Console.WriteLine();
        
    }
}
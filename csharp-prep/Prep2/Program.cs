using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write your grade: ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        string letterGrade = " ";

        if (grade <= 60)
        {
            letterGrade = ("F");
        }
        else if (grade <= 70)
        {
            letterGrade = ("D");
        }
        else if (grade <= 80)
        {
            letterGrade = ("C");
        }
        else if (grade <= 90)
        {
            letterGrade = ("B");
        }
        else
        {
            letterGrade = ("A Congratulations");
        }
        Console.WriteLine($"Your grade is {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("You have pass the class Good job.");
        }
        else
        {
            Console.WriteLine("Sorry, you can do better next time.");
        }
    }
}
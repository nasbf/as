using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Thomas Mancipe");
        assignment1.SetTopic("El quijote");
        Console.WriteLine(assignment1.Getsummary());

        Mathassignment assignment2 = new Mathassignment();
        assignment2.SetStudentName ("Matias Mancipe");
        assignment2.SetTopic("Fracciones");
        assignment2.SettextBookSection("division");
        assignment2.SetProblems("18-20");
        Console.WriteLine(assignment2.Getsummary());
        Console.WriteLine(assignment2.GetHomeWork());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName ("Fabio Mancipe");
        assignment3.SetTopic ("El clima en Colombia");
        assignment3.SetTitle ("Diversidad Geografica");
        Console.WriteLine(assignment3.Getsummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}
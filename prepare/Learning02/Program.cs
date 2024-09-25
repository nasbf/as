using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job ();
        job._company = "Microsoft";
        job._jobTitle = "Engineer";
        job._startYear = 2019;
        job._endYear = 2022;
        job.DisplayJd();
        

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.DisplayJd();


        Resume resume = new Resume ();
        resume._name = "Alexandra";
        resume.Displayname();
        resume._jobs.Add(job);
        resume._jobs.Add(job2);

        resume.Display();
       
    }
}
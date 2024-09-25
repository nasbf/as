using System.Reflection.Metadata;
public class Resume
{
    public string _name ="";
    public void Displayname ()
    {
        Console.WriteLine($"Name: {_name}");
    }

    
    public List<Job> _jobs = new List<Job> ();

    public void Display ()
    {
        Console.WriteLine($"Jobs: {_jobs}");

        foreach (Job x in _jobs)
        {
            x.DisplayJd();
        }
    }
}
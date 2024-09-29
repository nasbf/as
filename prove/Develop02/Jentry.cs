using System;


public class Jentry
{
    public string _date = "";
   
    public string _promptText = "";
    public string _entryText = "";


    public Jentry(string date, string prompt, string entryText)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entryText;

    }
    
    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
        Console.WriteLine();
        
    }

    public void saveFile(StreamWriter file)
    {
        file.WriteLine (_date);
        file.WriteLine (_promptText);
        file.WriteLine(_entryText);
        file.WriteLine();
    }
}
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List <Jentry> _entries = new List<Jentry> ();

    
    public void AddEntry (Jentry newEntry)
    {
       _entries.Add(newEntry);
       Console.WriteLine("your note was added");

    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                entry.saveFile(outputFile);
            }
        }
    }
    public void LoadToFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entryText = parts[2];
        }
    }




}
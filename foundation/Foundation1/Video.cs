using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    private string _autor;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video (string title, string autor, int lenght)
    {
        _title  = title;
        _autor = autor;
        _lenght = lenght;

    }

    public void addComment (Comment comment)
    {
        _comments.Add(comment);
    }
    
    public int Getcomment ()
    {
        return _comments.Count;
    }
    public void Display ()
    {
        Console.WriteLine($"Title: {_title}, Autor: {_autor}, Length in seconds: {_lenght}");
        //Console.WriteLine();
        Console.WriteLine($"Total comments: {Getcomment()}");
        //Console.WriteLine(_comments)
        foreach (var comment in _comments)
        {
            Console.WriteLine($"* {comment._person}: {comment._commentText}");
        }
        Console.WriteLine();
    }


}


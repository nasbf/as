using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video ("Receta", "Maria Mora", 5);
        video1.addComment(new Comment("Jose", "Gran video")); 
        video1.addComment(new Comment("Edi", "Me gusto"));
        video1.addComment(new Comment("Tomy", "Excelente"));
        

        Video video2 = new Video ("C#", "BYU", 60);
        video2.addComment(new Comment("Alexandra", "Gracias aprendi nucho")); 
        video2.addComment(new Comment("Fabio", "Buen manejo del tema"));
        video2.addComment(new Comment("Mati", "No habia encontrado nada igual"));
        //video2.Display();

        Video video3 = new Video ("La verdad", "Elder Holland", 40);
        video3.addComment(new Comment("Dani", "Excelente tema")); 
        video3.addComment(new Comment("Sandra", "Dió claridad a mi vida"));
        video3.addComment(new Comment("Juan", "Donde hayo mas información?"));
        //video2.Display();

        List <Video> videos = new List<Video>
        {video1, video2, video3};
        
        foreach (var video in videos)
        {
            video.Display();
        }


    }
}
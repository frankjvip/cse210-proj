using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear videos
        Video video1 = new Video("Intro to C#", "Alice", 300);
        video1.AddComment(new Comment("Bob", "Great explanation!"));
        video1.AddComment(new Comment("Charlie", "Very helpful, thanks."));
        video1.AddComment(new Comment("Dana", "Can you cover LINQ next?"));

        Video video2 = new Video("Cooking Pasta", "Chef Mario", 600);
        video2.AddComment(new Comment("Laura", "Looks delicious!"));
        video2.AddComment(new Comment("Sam", "I tried it, amazing recipe."));
        video2.AddComment(new Comment("Nina", "Can you do gluten-free?"));

        Video video3 = new Video("Travel Vlog: Paris", "Emily", 900);
        video3.AddComment(new Comment("Tom", "Beautiful shots!"));
        video3.AddComment(new Comment("Sophia", "I want to visit now."));
        video3.AddComment(new Comment("James", "What camera do you use?"));

        // Lista de videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Mostrar información
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}

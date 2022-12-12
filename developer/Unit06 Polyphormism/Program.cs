using System;
using System.Collections;
using System.Collections.Generic;

namespace Unit05
{
    class Program
    {
    private static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.Title = "Buildings in Tijuana";
        video1.Autor = "Veronica";
        video1.Length = 50;

        video1.comments = new List<Comment>();

        Comment comment1 = new Comment();
        comment1.Name = "Rodrigo";
        comment1.comment = "Here are a lot of houses with similar style of San Diego wood houses of 1 floor.";
        video1.comments.Add(comment1);

        comment1 = new Comment();
        comment1.Name = "Pedro";
        comment1.comment = "The big bussines buildings are in Zona Rio.";
        video1.comments.Add(comment1);

        comment1 = new Comment();
        comment1.Name = "Juan";
        comment1.comment = "The infrastructure in Tijuana is not enough for its population.";
        video1.comments.Add(comment1);

        videos.Add(video1);


        Video video2 = new Video();
        video2.Title = "Food in Tijuana";
        video2.Autor = "Libia Galvan";
        video2.Length = 60;

        video2.comments = new List<Comment>();

        Comment comment2 = new Comment();
        comment2.Name = "Mauricio";
        comment2.comment = "The Ceasar salad was created in Tijuana!";
        video2.comments.Add(comment2);

        comment2 = new Comment();
        comment2.Name = "Karla";
        comment2.comment = "Baja-med cuisine is delicious.";
        video2.comments.Add(comment2);

        comment2 = new Comment();
        comment2.Name = "Ivan";
        comment2.comment = "Gastronomic food trucks are very popular in TJ.";
        video2.comments.Add(comment2);
        videos.Add(video2);

        comment2 = new Comment();
        comment2.Name = "Victoria";
        comment2.comment = "The best tacos of Mexico are in TIjuana!";
        video2.comments.Add(comment2);
        videos.Add(video2);


        Video video3 = new Video();
        video3.Title = "Education in Tijuana";
        video3.Autor = "Isaac Vega";
        video3.Length = 45;

        video3.comments = new List<Comment>();

        Comment comment3 = new Comment();
        comment3.Name = "Ariel";
        comment3.comment = "Cetys is one of the best universities here.";
        video3.comments.Add(comment3);

        comment3 = new Comment();
        comment3.Name = "Martha";
        comment3.comment = "Tijuana has more universities per capita than other cities of Mexico";
        video3.comments.Add(comment3);

        comment3 = new Comment();
        comment3.Name = "Daniel";
        comment3.comment = "There are a few scools that still take advantage of remote posibilities.";
        video3.comments.Add(comment3);
        videos.Add(video3);

        int countvideo = 0;

        foreach (var video in videos)
        {
            countvideo++;

            Console.WriteLine("");
            Console.WriteLine("Video #" + countvideo);
            Console.WriteLine(" ");
            Console.WriteLine("Title: " + video.Title + ", Autor: " + video.Autor + ", Time: " + video.Length + " seconds.");
            Console.WriteLine(" ");

            int countComment = 0;
            foreach (var comment in video.comments)
            {
                countComment = video.CountComments(countComment);

                Console.WriteLine("Comment # " + countComment.ToString());
                Console.WriteLine("Author: " + comment.Name);
                Console.WriteLine("Comment: " + comment.comment);
                Console.WriteLine("");
            }
            Console.WriteLine("Number of comments: " + countComment.ToString());
            Console.WriteLine(" ");
            
        }


        Console.ReadLine();
    }
}
}
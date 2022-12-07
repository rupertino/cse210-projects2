using System;
using System.Collections;
using System.Collections.Generic;

namespace Unit05
{
    internal class Program
    {
    private static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.Title = "Tijuana";
        video1.Autor = "Veronica";
        video1.Length = 50;

        video1.comments = new List<Comment>();

        Comment comment1 = new Comment();
        comment1.Name = "Rodrigo";
        comment1.comment = "is good";
        video1.comments.Add(comment1);


        comment1 = new Comment();
        comment1.Name = "Pedro";
        comment1.comment = "Is bad";
        video1.comments.Add(comment1);


        comment1 = new Comment();
        comment1.Name = "Juan";
        comment1.comment = "Is broken";
        video1.comments.Add(comment1);

        videos.Add(video1);

        Video video2 = new Video();
        video2.Title = "Tijuana";
        video2.Autor = "Veronica";
        video2.Length = 50;

        video2.comments = new List<Comment>();

        Comment comment2 = new Comment();
        comment2.Name = "Rodrigo";
        comment2.comment = "is good";
        video2.comments.Add(comment2);


        comment2 = new Comment();
        comment2.Name = "Pedro";
        comment2.comment = "Is bad";
        video2.comments.Add(comment2);


        comment2 = new Comment();
        comment2.Name = "Juan";
        comment2.comment = "Is broken";
        video2.comments.Add(comment2);
        videos.Add(video2);

        Video video3 = new Video();
        video3.Title = "Tijuana";
        video3.Autor = "Veronica";
        video3.Length = 50;

        video3.comments = new List<Comment>();

        Comment comment3 = new Comment();
        comment3.Name = "Rodrigo";
        comment3.comment = "is good";
        video3.comments.Add(comment3);


        comment3 = new Comment();
        comment3.Name = "Pedro";
        comment3.comment = "Is bad";
        video3.comments.Add(comment3);


        comment3 = new Comment();
        comment3.Name = "Juan";
        comment3.comment = "Is broken";
        video3.comments.Add(comment3);
        videos.Add(video3);

        int countvideo = 0;

        foreach (var video in videos)
        {
            countvideo++;

            Console.WriteLine("");
            Console.WriteLine("Video number: " + countvideo);
            Console.WriteLine(" ");
            Console.WriteLine("Title: " + video.Title + " Autor: " + video.Autor + "Time: " + video.Length);
            Console.WriteLine(" ");

            int countComment = 0;
            foreach (var comment in video.comments)
            {
                countComment = video.CountComments(countComment);

                Console.WriteLine("Number Comment: " + countComment.ToString());
                Console.WriteLine("Name: " + comment.Name);
                Console.WriteLine("Comment: " + comment.comment);
            }
            Console.WriteLine("Total Comment: " + countComment.ToString());
            Console.WriteLine(" " + countComment.ToString());
        }


        Console.ReadLine();
    }
}
}
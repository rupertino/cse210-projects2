using System;
using System.Collections;
using System.Collections.Generic;

namespace Unit06
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Video video1 = new Video();
            video1._title = "Tijuana";
            video1._autor = "Veronica";
            video1._length = 50;
            
            video1._videoComments = new List<Comment>();            
            video1._videoComments.Add(new Comment() {_nameOfCommenter = "Carlos", _text = "The city is growing!"});
            video1._videoComments.Add(new Comment() {_nameOfCommenter = "Daniel", _text = "I love this city."});
            video1._videoComments.Add(new Comment() {_nameOfCommenter = "Angel", _text = "I used to live in Tijuana."});
            
            Video video2 = new Video();
            video2._title = "Cancun";
            video2._autor = "Magali";
            video2._length = 85;
            
            video2._videoComments = new List<Comment>();            
            video2._videoComments.Add(new Comment() {_nameOfCommenter = "Jeremy", _text = "It is a beatiful place."});
            video2._videoComments.Add(new Comment() {_nameOfCommenter = "Carmi", _text = "The sea is of a unque blue color in Cancun."});
            video2._videoComments.Add(new Comment() {_nameOfCommenter = "Tommy", _text = "It's a great place to visit with the family."});
            
            Video video3 = new Video();
            video3._title = "Monterrey";
            video3._autor = "Ulises";
            video3._length = 60;
            
            video3._videoComments = new List<Comment>();            
            video3._videoComments.Add(new Comment() {_nameOfCommenter = "Robert", _text = "The city is huge!"});
            video3._videoComments.Add(new Comment() {_nameOfCommenter = "Alan", _text = "People in Monterrey loves doing barbecues."});
            video3._videoComments.Add(new Comment() {_nameOfCommenter = "Gregorio", _text = "There's a beautiful Temple in Monterrey."});
        
            var videos = new List<Video> {video1, video2, video3};
        
            foreach(var Video in videos)
            {
                Console.WriteLine(Video._autor);
                Console.WriteLine(Video._length);
                Console.WriteLine(Video._title);
                Video.CountOfComments();
                Console.ReadLine();
                Console.Write(Video._videoComments[0]);
           
                
                
            }
            
            
           //foreach(var  )
           // {
           //     Console.WriteLine($"Name: {Comment.}");
           //     Console.WriteLine($"Comment: {Comment._text}");
           // }    
            
                
            //    
        }

             

    }
}

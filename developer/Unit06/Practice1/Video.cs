using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _autor;
    public int _length;
    public List<Comment> _videoComments; //= new List<Comment>();
    public void CountOfComments()
    {
        Console.WriteLine(_videoComments.Count);
    }


}
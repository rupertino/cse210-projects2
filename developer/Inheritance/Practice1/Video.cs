using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Autor { get; set; }
    public int Length { get; set; }
    public List<Comment> comments { get; set; }


    public int CountComments(int count) {

        count++;
        return count;
    }
}
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the YouTubeVideos Project.");

        Video video1 = new Video("Something1", "Jose Brito", 900);
        Comment comment1 = new Comment("julia", "this is a test1");
        Comment comment2 = new Comment("julia2", "this is a test2");
        video1.AddComment(comment1);
        video1.AddComment(comment2);

        Video video2 = new Video("Something2", "Jose2 Brito2", 1900);
        Comment comment3 = new Comment("julia", "this is a test1");
        Comment comment4 = new Comment("julia2", "this is a test2");
        video2.AddComment(comment3);
        video2.AddComment(comment4);


        video1.DisplayInfo();
        video2.DisplayInfo();


    }
}
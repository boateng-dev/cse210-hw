using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 360);
        video1.AddComment(new Comment("David Mensah", "Great video!"));
        video1.AddComment(new Comment("Rita Menu", "Love it!"));
        video1.AddComment(new Comment("Bob Smith", "Awesome content!"));

        Video video2 = new Video("Video 2", "Author 2", 420);
        video2.AddComment(new Comment("Alice Johnson", "Good stuff!"));
        video2.AddComment(new Comment("Mike Brown", "Nice video!"));
        video2.AddComment(new Comment("Emily Davis", "Keep it up!"));

        Video video3 = new Video("Video 3", "Author 3", 480);
        video3.AddComment(new Comment("Tom Harris", "Excellent!"));
        video3.AddComment(new Comment("Linda Lee", "Well done!"));
        video3.AddComment(new Comment("David Kim", "Great job!"));

        // Add videos to list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display videos
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment.Author}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
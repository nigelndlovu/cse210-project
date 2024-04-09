using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        for (int v = 0; v < 3; v++)
        {
            Console.WriteLine($"Enter details for Video {v + 1}:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Length (in seconds): ");
            int lengthSeconds = int.Parse(Console.ReadLine());

            Video video = new Video(title, author, lengthSeconds);
            videos.Add(video);

            Console.WriteLine($"Enter comments for Video {v + 1}:");
            for (int c = 0; c < 3; c++)
            {
                Console.Write($"Comment {c + 1} - Commenter Name: ");
                string commenterName = Console.ReadLine();
                Console.Write($"Comment {c + 1} - Text: ");
                string text = Console.ReadLine();
                Comment comment = new Comment(commenterName, text);
                video.Comments.Add(comment);
            }
        }

        Console.WriteLine("\nVideo Information:");
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
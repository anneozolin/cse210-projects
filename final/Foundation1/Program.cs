using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create some videos and add comments
        Video video1 = new Video();
        video1._title = "First Video";
        video1._author = "Person 1";
        video1._length = 120;
        video1.AddComment(new Comment() { CommenterName = "John", CommentText = "Great video!" });
        video1.AddComment(new Comment() { CommenterName = "Maria", CommentText = "Very helpful." });
        video1.AddComment(new Comment() { CommenterName = "Bob", CommentText = "Thanks for sharing." });
        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Second Video";
        video2._author = "Person 2";
        video2._length = 180;
        video2.AddComment(new Comment() { CommenterName = "Alice", CommentText = "Awesome tutorial!" });
        video2.AddComment(new Comment() { CommenterName = "Tom", CommentText = "I learned a lot from this." });
        video2.AddComment(new Comment() { CommenterName = "Miguel", CommentText = "Can't wait to try this." });
        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Third Video";
        video3._author = "Person 3";
        video3._length = 180;
        video3.AddComment(new Comment() { CommenterName = "Lucas", CommentText = "Awesome tutorial!" });
        video3.AddComment(new Comment() { CommenterName = "Mathew", CommentText = "Can't wait to try this." });
        video3.AddComment(new Comment() { CommenterName = "James", CommentText = "This was so helpful. Thank you!" });
        videos.Add(video3);

        // Display the videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of comments: " + video.CommentCount);
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.CommentText);
            }
            Console.WriteLine();
        }
    }
}
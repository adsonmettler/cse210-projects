using System;

class Program
{
    static void Main(string[] args)
    {
        // List to store videos
            List<Video> videos = new List<Video>();

            // Creating sample videos
            Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
            Video video2 = new Video("The Secrets of Space", "Dr. Smith", 1200);
            Video video3 = new Video("Learn C# in 10 Minutes", "Code Academy", 900);

            // Adding comments to the first video
            video1.AddComment(new Comments("Alice", "This is so helpful!"));
            video1.AddComment(new Comments("Bob", "Great recipe, I loved it!"));
            video1.AddComment(new Comments("Charlie", "Very detailed, thanks!"));

            // Adding comments to the second video
            video2.AddComment(new Comments("Dave", "Mind-blowing facts!"));
            video2.AddComment(new Comments("Eve", "Can't wait to see more videos."));
            video2.AddComment(new Comments("Frank", "Well explained!"));

            // Adding comments to the third video
            video3.AddComment(new Comments("Grace", "I finally understand C# now!"));
            video3.AddComment(new Comments("Hank", "Very concise and clear."));
            video3.AddComment(new Comments("Ivy", "Amazing tutorial, thank you!"));

            // Adding videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Displaying video details
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                foreach (Comments comment in video.Comments)
                {
                    Console.WriteLine($"{comment.Name}: {comment.TextComment}");
                }
                Console.WriteLine();
            }
            
    }
}
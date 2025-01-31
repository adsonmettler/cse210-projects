using System;

class Program
{
    static void Main(string[] args)
    {
            // List to store videos 
            List<Video> videos = new List<Video>();

            // Creating sample videos (Instantiation)
            Video video1 = new Video("The Film Look for ANY Camera", "Peter McKinnon", 265);
            Video video2 = new Video("the ONLY way to run Deepseek...", "NetworkChuck", 718);
            Video video3 = new Video("Project MINI RACK - a Homelab Revolution!", "Jeff Geerling", 900);

            // Adding comments to the first video (Instantiation)
            video1.AddComment(new Comments("Cao024", "Gotta show the results of using it in the vid Pete!"));
            video1.AddComment(new Comments("jakubphotography", "We need a 135 vs Shortstache filter comparison video!"));
            video1.AddComment(new Comments("Synmomusic", "Do you have any examples of photos shot with these filters?"));

            // Adding comments to the second video (Instantiation)
            video2.AddComment(new Comments("tubularjoint", "Deepseek recommended your channel for cybersecurity. I checked this morning"));
            video2.AddComment(new Comments("EyosiB", "I'm running 14b on my M3 pro 18GB RAM 😊🎉"));
            video2.AddComment(new Comments("jochemw97", "Quick summary of every info we need without dragging it to 30 mins... Well done! Very informative and useful :)"));

            // Adding comments to the third video (Instantiation)
            video3.AddComment(new Comments("TechnoTime", "Thanks for letting me join in on the (mini) revolution!"));
            video3.AddComment(new Comments("HardwareHaven", "Great video! I can’t wait to try out the lab stack mini stuff — it looks so awesome!"));
            video3.AddComment(new Comments("Krogren", "This is exactly what I've been looking for and trying to figure out what to build! Thanks for sharing the project."));

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
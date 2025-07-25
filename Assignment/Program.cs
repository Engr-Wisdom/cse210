using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video1 = new Video("How to Bake Bread", "Chef John", 3000);
        video1.AddComment(new Comment("Mary", "Great tutorial!"));
        video1.AddComment(new Comment("Bright", "I tried it and it worked"));
        video1.AddComment(new Comment("James", "Can I use almond flour?"));

        Video video2 = new Video("Learn C# in 10 Minutes", "DevWizard", 11000);
        video2.AddComment(new Comment("Alice", "Super helpful"));
        video2.AddComment(new Comment("Ben", "More videos please"));
        video2.AddComment(new Comment("David!", "Thanks"));
        video2.AddComment(new Comment("Carla", "I love the explanation"));

        Video video3 = new Video("Software Engineer Roadmap", "Wisdom Effiong", 5000);
        video3.AddComment(new Comment("Elisha", "Thank you for the roadmap"));
        video3.AddComment(new Comment("Destiny", "Please create a video for cybersecurity roadmap"));
        video3.AddComment(new Comment("Victor", "I am so clarified with your video"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}

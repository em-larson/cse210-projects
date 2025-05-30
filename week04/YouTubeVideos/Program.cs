using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Comment c1 = new Comment("jlarson", "Loved the video! Inspirational!!");
        Comment c2 = new Comment("AWatkins", "This has actually changed my life. 10/10");
        Comment c3 = new Comment("ironman", "Not sure why I just watched this entire video, but I couldn't look away.");

        Video v1 = new Video("Tinkerbell", "How to: keep the pom poms clean on your shoes", 577, [c1, c2, c3]);

        Comment c4 = new Comment("skmusic", "beautiful and mezmerizing");
        Comment c5 = new Comment("ag502", "I had to watch multiple times to reassure myself that those wisps of dust were not portions of my soul leaving my body");
        Comment c6 = new Comment("torlink", "Its amazing to see someone exactly where they should be.");

        Video v2 = new Video("Rachel Hardy", "Stranger Things S4: Running Up That Hill", 300, [c4, c5, c6]);

        Comment c7 = new Comment("john", "I sit here writing thie review at 4 AM from my porcelain throne, a fixture you wil become all too familaiar with if you choose to eat these cute little bears from the pits...");
        Comment c8 = new Comment("zack", "I'm a terrible person, I bought these and put them in a bowl on my desk. My coworkers have all told me they thought they were dying. They haven't put two and two together yet.");
        Comment c9 = new Comment("avenue", "Moral of the story: Donw mess with the sugar-free gummy bears.");
        Comment c10 = new Comment("kb", "If you or a loved one have suffered from sugar free gummi bears, you may be entitled to compensation");

        Video v3 = new Video("seymore", "Haribo Sugar Free classic Gummi Bears", 427, [c7, c8, c9, c10]);

        List<Video> videos = new List<Video> { v1, v2, v3 };

        foreach (Video v in videos)
        {
            Console.WriteLine("");
            Console.WriteLine($"Number of Comments: {v.NumberComments()}");
            v.DisplayInfo();
        }

    }
}
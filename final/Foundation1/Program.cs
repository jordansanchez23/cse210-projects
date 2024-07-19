using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 300);
        Video video2 = new Video("Video 2", "Author 2", 600);
        Video video3 = new Video("Video 3", "Author 3", 900);

        video1.addComment(new Comment("User 1", "Comment 1 in Video 1"));
        video1.addComment(new Comment("User 2", "Comment 2 in Video 2"));
        video1.addComment(new Comment("User 3", "Comment 3 in Video 3"));

        video2.addComment(new Comment("User 4", "Comment 4 in Video 4"));
        video2.addComment(new Comment("User 5", "Comment 5 in Video 5"));
        video2.addComment(new Comment("User 6", "Comment 6 in Video 6"));

        video3.addComment(new Comment("User 7", "Comment 7 in Video 7"));
        video3.addComment(new Comment("User 8", "Comment 8 in Video 8"));
        video3.addComment(new Comment("User 9", "Comment 9 in Video 9"));

        List<Video> videos = new List<Video> {video1,video2,video3};

        foreach (Video video in videos)
        {
            Console.WriteLine(video.getVideoInfo());
            video.displayComments();
            Console.WriteLine();
        }
    }
}
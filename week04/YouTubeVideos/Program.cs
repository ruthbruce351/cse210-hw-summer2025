using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.DisplayVideo("Learning to Sew", "Beth Bruce", 300);
        video1.AddComment(new Comment { _commenter = "Emily", _commentText = "Love it!" });
        video1.AddComment(new Comment { _commenter = "Anna", _commentText = "Can you make more videos?" });
        video1.AddComment(new Comment { _commenter = "Michael", _commentText = "I want to do this!" });
        video1.AddComment(new Comment { _commenter = "Josh", _commentText = "So cool!" });
        videos.Add(video1);

        Video video2 = new Video();
        video2.DisplayVideo("Baseball Draft Thoughts", "Malan Blake", 450);
        video2.AddComment(new Comment { _commenter = "Ruth", _commentText = "What did you think about Kumar Rocker?" });
        video2.AddComment(new Comment { _commenter = "Emma", _commentText = "This really made me think!" });
        video2.AddComment(new Comment { _commenter = "Henry", _commentText = "I agree with this!" });
        videos.Add(video2);

        Video video3 = new Video();
        video3.DisplayVideo("Top 10 Vacations", "Stephanie Blake", 600);
        video3.AddComment(new Comment { _commenter = "David", _commentText = "Those were my favorites too!" });
        video3.AddComment(new Comment { _commenter = "Simon", _commentText = "What about the Alaska trip?" });
        video3.AddComment(new Comment { _commenter = "Deborah", _commentText = "Love the pictures!!" });
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}, Author: {video._author}, Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._commenter}: {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}
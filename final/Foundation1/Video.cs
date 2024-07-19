public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public  List<Comment> _comments;
    public int _numberOfComments;


    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
        _numberOfComments = 0;
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
        _numberOfComments++;
    }

    public string getVideoInfo()
    {
        return $"Title: {_title}, Author: {_author}, Length: {_lengthInSeconds} seconds, Number of Comments: {_numberOfComments}";
    }

    public void displayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.getCommentInfo());
        }
    }
}
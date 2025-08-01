class Comment
{
    public string _commenter;
    public string _commentText;

    public void DisplayComment(string commenter, string commentText)
    {
        _commenter = commenter;
        _commentText = commentText;
    }
}
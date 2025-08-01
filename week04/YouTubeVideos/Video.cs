class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public void DisplayVideo (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
}
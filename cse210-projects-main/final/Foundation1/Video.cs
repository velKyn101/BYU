using System.Dynamic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;


    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _length = lengthInSeconds;
        _comment = new List<Comment>();
    }


    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public void SetComments(Comment comments)
    {
        _comment.Add(comments);
    }
    public int ComputeTotalComments()
    {
        return _comment.Count;
    }


    public void Display()
    {
        Console.WriteLine($"Title: {_title} \nAuthor: {_author} \nLength: {_length} \n");
    }
}
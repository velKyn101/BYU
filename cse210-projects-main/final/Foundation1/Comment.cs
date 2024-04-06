public class Comment
{
    private string _userName {get; set;}
    private string _comment {get; set;}

    public Comment(string userName, string comment)
    {
        _userName = userName;
        _comment = comment;

    }

    public string GetComment()
    {
        return _comment;
    }
    public void Display()
    {
        Console.WriteLine($"{_userName}: {_comment}");
    }
}
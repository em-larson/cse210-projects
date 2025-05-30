using System.Net;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
    private string _author;
    private string _title;
    private int _length;
    private List<Comment> _comments;

    public Video()
    {
        _author = "";
        _title = "";
        _length = 0;
        _comments = [];
    }

    public Video(string author, string title, int length, List<Comment> comments)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments = comments;
    }

    public int NumberComments()
    {
        int length = _comments.Count;
        return length;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_title}: {_author}, {_length}");
        foreach (Comment c in _comments)
        {
            Console.WriteLine(c.DisplayComment());
        }
    }

}


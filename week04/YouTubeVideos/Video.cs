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

    public int NumberComments()
    {
        int length = _comments.Count;
        return length;
    }



}


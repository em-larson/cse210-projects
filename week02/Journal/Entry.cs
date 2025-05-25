public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        _date = "";
        _promptText = "";
        _entryText = "";
    }

    public void Display()
    {
        _date = System.DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }
}
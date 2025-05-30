public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "";
        _isHidden = false;
    }

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        string tempString = "";
        for (int i = 0; i < _text.Length; ++i)
        {
            tempString += "_";
        }
        _text = tempString;
        _isHidden = true;
    }

    public void Show()
    {
        //This is going to show the word? Not sure when this would be used? is this just dead code? It seems like it. 
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}
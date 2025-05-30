public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        List<string> words = text.Split(' ').ToList();
        foreach (string w in words)
        {
            Word tempWord = new Word(w);
            _words.Add(tempWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int length = _words.Count();
        int[] indexes = new int[length];

        for (int i = 0; i < length; ++i)
        {
            indexes[i] = i;
        }

        Random.Shared.Shuffle(indexes);

        int hiddenCount = 0;

        foreach (int i in indexes)
        {
            int randomIndex = indexes[i];

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                ++hiddenCount;
            }

            if (hiddenCount >= numberToHide)
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string output = _reference.GetDisplayText();

        foreach (Word w in _words)
        {
            output += $"{w.GetDisplayText()} ";
        }

        return output;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (w.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}
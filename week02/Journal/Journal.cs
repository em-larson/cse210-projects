using Microsoft.VisualBasic;
using System.IO;
using System.Reflection.Metadata.Ecma335;


public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("");
            entry.Display();
        }
        Console.WriteLine("");
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
            }

        }
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Importing Journal...");
        // List<Entry> _entries = new List<Entry>();
        _entries.Clear();
        // string file = filename;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry newentry = new Entry();
            newentry._date = parts[0];
            newentry._promptText = parts[1];
            newentry._entryText = parts[2];

            _entries.Add(newentry);
        }

    }

}
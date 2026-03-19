using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries { get; set; }

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} {entry._prompt} {entry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("");
            Entry entry = new Entry(parts[1], parts[2], parts[0]);
            _entries.Add(entry);
        }
    }
}
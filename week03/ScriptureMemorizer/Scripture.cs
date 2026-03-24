using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(Words.Count);
            Words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = Reference.ToString() + Environment.NewLine;
        foreach (Word word in Words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text;
    }
}
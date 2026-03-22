using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        var visibleWords = words.Where(w => !w.IsHidden).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllHidden => words.All(w => w.IsHidden);

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.ToString());
        Console.WriteLine(string.Join(" ", words.Select(w => w.Display())));
    }
}

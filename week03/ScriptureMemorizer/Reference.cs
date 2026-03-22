using System;

public class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    // Single verse builder
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse;
    }

    // Builder for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse == StartVerse
            ? $"{Book} {Chapter}:{StartVerse}"
            : $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}

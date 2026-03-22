using System;

public class Word
{
    private string text;
    private bool hidden;

    public Word(string word)
    {
        text = word;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden => hidden;

    public string Display()
    {
        return hidden ? new string('_', text.Length) : text;
    }
}

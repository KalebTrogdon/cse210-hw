using System;

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void RemoveWordAndLeaveFirstLetter()
    {
        Text = Text[0] + new string('_', Text.Length - 1);
        IsHidden = true;
    }
}

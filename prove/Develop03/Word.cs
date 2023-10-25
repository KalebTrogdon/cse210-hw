using System;

public class Word
{
    public string FirstLetter { get; private set; }
    public string RestOfWord { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        FirstLetter = text.Length > 0 ? text[0].ToString() : "";
        RestOfWord = text.Length > 1 ? text.Substring(1) : "";
        IsHidden = false;
    }

    public void RemoveWordAndLeaveFirstLetter()
    {
        RestOfWord = new string('_', RestOfWord.Length);
        IsHidden = true;
    }
}

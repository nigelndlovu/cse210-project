using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden() && numberToHide())
            {
                word.Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetReferenceText()
    {
        return _reference.GetDisplayText();
    }

    private bool numberToHide()
    {
        Random random = new Random();
        return random.Next(2) == 0;
    }
}

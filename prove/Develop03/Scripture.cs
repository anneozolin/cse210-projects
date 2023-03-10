using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string referenceString, string text)
    {
        _reference = new Reference(referenceString);
        _words = new List<Word>();

        // split the text into words and add them to the list of words
        string[] wordStrings = text.Split(' ');

        foreach (string wordString in wordStrings)
        {
            _words.Add(new Word(wordString));
        }
    }

    public bool AllWordsHidden
    {
        get
        {
            // check if all words have been hidden
            foreach (Word word in _words)
            {
                if (!word.Hidden)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public void HideRandomWords()
    {
        // hide a few random words
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public override string ToString()
    {
        // build a string representation of the scripture
        string result = _reference + "\n\n";

        foreach (Word word in _words)
        {
            result += word + " ";
        }

        return result;
    }
}
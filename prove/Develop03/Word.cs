class Word
{
    private string wordString;
    private bool hidden;

    public Word(string wordString)
    {
        this.wordString = wordString;
        hidden = false;
    }

    public bool Hidden
    {
        get
        {
            return hidden;
        }
    }

    public void Hide()
    {
        hidden = true;
    }

    public override string ToString()
    {
        if (hidden)
        {
            return "_____";
        }
        else
        {
            return wordString;
        }
    }
}
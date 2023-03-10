class Word
{
    private string _wordString;
    private bool _hidden;

    public Word(string wordString)
    {
        this._wordString = wordString;
        _hidden = false;
    }

    public bool Hidden
    {
        get
        {
            return _hidden;
        }
    }

    public void Hide()
    {
        _hidden = true;
    }

    public override string ToString()
    {
        if (_hidden)
        {
            return "_____";
        }
        else
        {
            return _wordString;
        }
    }
}
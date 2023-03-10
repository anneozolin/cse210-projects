class Reference
{
    private string _referenceString;

    public Reference(string referenceString)
    {
        this._referenceString = referenceString;
    }

    public override string ToString()
    {
        return _referenceString;
    }
}
class Reference
{
    private string referenceString;

    public Reference(string referenceString)
    {
        this.referenceString = referenceString;
    }

    public override string ToString()
    {
        return referenceString;
    }
}
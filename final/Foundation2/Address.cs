class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateProvince = stateProvince;
        this._country = country;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool IsUSAddress()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddressDetails()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}
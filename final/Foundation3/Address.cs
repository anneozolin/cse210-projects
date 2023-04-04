public class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    public Address(string street, string city, string state, string zip) {
        this._street = street;
        this._city = city;
        this._state = state;
        this._zip = zip;
    }

    public override string ToString() {
        return $"{_street}\n{_city}, {_state} {_zip}";
    }
}
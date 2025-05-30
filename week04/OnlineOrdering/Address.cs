using System.Collections.Concurrent;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool InUS()
    {
        if (_country == "US" || _country == "USA" || _country == "United States")
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        return $"{_street} \n {_city} {_stateProvince}, {_country}";
    }

}
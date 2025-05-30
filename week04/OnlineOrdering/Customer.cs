using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    public bool InUS()
    {
        if (_address.InUS() == true)
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    public string GetName()
    {
        return $"{_name}";
    }

    public string GetAddress()
    {
        return _address.DisplayAddress();
    }
}
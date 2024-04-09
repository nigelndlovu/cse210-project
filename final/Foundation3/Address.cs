using System;

public class Address
{
    public string _street { get; set; }
    public string _city { get; set; }
    public string _state { get; set; }
    public string _country { get; set; }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}
using System;
using System.Runtime.CompilerServices;
using System.Text;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool GetIfResidence()
    {
        string[] countryTags = ["usa", "ee.uu", "us", "united states", "united states of america"];
        return countryTags.Contains(_country.ToLower());
    }

    public string GetFullAddress() => $"Address: {_street}, {_city}\n{_state}, {_country}";

}
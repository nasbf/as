using System;
using System.Collections.Generic;


public class Addres
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Addres (string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string Getstreet ()
    {
        return _street;
    }
    public string Getcity()
    {
        return _city;
    }
    public string Getstate()
    {
        return _state;
    }
    public bool InUsa()
    {
        return _country.ToLower() == "usa";
    }


    public string GetAddres()
    {
        return $"{_street} - {_city}/{_state} - {_country}\n";
    }

}
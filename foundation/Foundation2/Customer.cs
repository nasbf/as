using System;
using System.Collections.Generic;


public class Customer
{
    private string _name;
    private Addres _addres;

    public Customer (string name, Addres addres)
    {
        _name = name;
        _addres = addres;
    }

    public string GetName ()
    {
        return _name;
    }

    public bool inUsa()
    {
        return _addres.InUsa();
    }
    public string DisplayAddresLable ()
    {
        return $"{_name}\n{_addres.GetAddres()}";
        
        
         
     
    }

}
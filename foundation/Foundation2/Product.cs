using System;
using System.Collections.Generic;


public class Product

{
    private int _idProduct;
    private string _nameProduct;
    private int _price;
    private int _quantity;

    public Product (int idProduct, string nameProduct, int price, int quantity)
    
    {
        _idProduct = idProduct;
        _nameProduct = nameProduct;
        _price = price;
        _quantity = quantity;
    }

    public int GetIdProduct()
    {
        return _idProduct;
    }    
    public string GetNameProduct()
    {
        return _nameProduct;
    }   
    public int GetPrice()
    {
        return _price;
    }   
    public int GetQuantity()
    {
        return _quantity;
    }
    

    public int GetTotalPrice ()
    {
       return  _price * _quantity;
        
    }
    // public string GetPackingLable ()
    // {
    //     return $"Id Product: {_idProduct}\nProduct: {_nameProduct}";
    // }
}
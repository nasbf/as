using System;
using System.Collections.Generic;


public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct (Product product)
    {
        _products.Add(product);
    }

    public int GetShippingCost ()
    {
        if (_customer.inUsa())
        {
            return 5;
        }
        else
        {
            return 35;
        }
        
    }


  
    public string GetTotalCost ()
        {
            int totalCost = 0;
            foreach (var product in _products)
        {
            
            totalCost += product.GetTotalPrice();
           
        }
        return $"Total Cost: ${totalCost + GetShippingCost()}\n";
    }


    public string GetPackingLable()
    {
        string lable = "";
        foreach (var product in _products)
        {
            lable += $"Id product: {product.GetIdProduct()}\nProduct: {product.GetNameProduct()}\n";
        }
        return lable;
    }

    public string GetShippingLable ()
    {
        return _customer.DisplayAddresLable ();
        
    }


}
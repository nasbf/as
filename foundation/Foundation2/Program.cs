using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        
        Addres addres1 = new Addres("Kr 8 6-01 ", "Bogota", "cundinamarca", "colombia");
          
    
        Customer customer1 = new Customer ("Maria Perez", addres1);
        
        
        Product product1 = new Product (130, "Chunky Pollo", 185000, 25);
        Product product2 = new Product (150, "Mirringo", 67000, 8);

        Order order1 = new Order(customer1); 
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Console.WriteLine(order1.GetShippingLable ());
        Console.WriteLine(order1.GetPackingLable ());
        //Console.WriteLine();
        Console.WriteLine(order1.GetTotalCost());

        Addres addres2 = new Addres ("Miami 150", "Miami", "Miami", "USA");
        Customer customer2 = new Customer ("Jorge Navarro", addres2);
        Product product3 = new Product (110, "Chunky Cordero", 220000, 12);
        Product product4 = new Product (80, "Monello Raza Pequeña", 250000, 8);
        Product product5 = new Product (10, "Monello Cachorro", 300000, 25);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        Console.WriteLine(order2.GetShippingLable());
        Console.WriteLine(order2.GetPackingLable());
        Console.WriteLine(order2.GetTotalCost());
        }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square ("Azul", 15);
        

        Rectangle rectangle = new Rectangle ("amarillo", 10, 5);
        

        Circle circle = new Circle ("Rojo", 20);
        

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add (rectangle);
        shapes.Add(circle);

        foreach (Shape x in shapes)
        {
            string color = x.GetColor();
            double area = x.GetArea();
            Console.WriteLine($"Color: {color}, Area: {area}");
        } 
             
    }
}
using System;

public class Circle : Shape
{

    private double _ratio;

    public double GetRatio ()
    {
        return _ratio;

    }

    public void SetRatio (double ratio)
    {
        _ratio = ratio;  
    }
    
    public Circle (string color, double ratio) : base(color)
    {
        _ratio = ratio;
    }
    

    public override double GetArea()
    {
        return Math.Pow(_ratio, 2) * Math.PI;
    }
}






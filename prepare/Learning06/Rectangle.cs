using System;

public class Rectangle : Shape
{

    private int _sideA;
    private int _sideB;

    public int GetSideA ()
    {
        return _sideA;

    }

    public void SetSideA (int side)
    {
        _sideA = side;  
    }
    
    public int GetSideB ()
    {
        return _sideB;

    }

    public void SetSideB (int sideB)
    {
        _sideB = sideB;  
    }
    
    public Rectangle (string color, int side, int sideB) : base(color)
    {
        _sideA = side;
        _sideB = sideB;
    }

    public override double GetArea()
    {
        return _sideA * _sideB;
    }
}






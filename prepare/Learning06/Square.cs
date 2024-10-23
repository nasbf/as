using System;

public class Square : Shape
{

    private int _side;

    public int GetSide ()
    {
        return _side;

    }

    public void SetSide (int side)
    {
        _side = side;  
    }
    
    public Square (string color, int side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}






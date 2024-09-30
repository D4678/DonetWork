using System;

class circle
{
    static float _PI;
    int _Radius;

    static circle()
    {
        Console.WriteLine("static Construtor called");
        circle._PI = 3.14F;
    }

    public circle(int Radius)
    {
        Console.WriteLine("instance Contructor called");
        _Radius = Radius;
    }

    public float CalculateArea()
    {
        return circle._PI * this._Radius * this._Radius;
    }
}

class Test
{
    public static void Main()
    {
        circle c = new circle(5);
        float area = c.CalculateArea();
        Console.WriteLine("The Radius = {0} ", area);

        circle c1 = new circle(8);
        float area1 = c1.CalculateArea();
        Console.WriteLine("The Radius = {0} ", area1);
    }
}

using System;

class Complex
{
    double x;
    double y;

    public Complex()
    {
    }

    public Complex(double real, double img)
    {
        x = real;
        y = img;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex c3 = new Complex();
        c3.x = c1.x + c2.x;
        c3.y = c1.y + c2.y;
        return c3;
    }

    public void display()
    {
        Console.Write(x);
        Console.Write("+j" + y);
        Console.WriteLine();
    }
}

class ComplexTest
{
    public static void Main()
    {
        Complex a, b, c;
        a = new Complex(2.5, 3.5);
        b = new Complex(1.6, 2.7);
        c = a + b;

        Console.Write("a = ");
        a.display();
        Console.Write("b = ");
        b.display();
        Console.Write("c = ");
        c.display();

        Console.ReadLine();
    }
}

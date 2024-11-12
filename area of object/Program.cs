using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaOfAnObject
{
    interface Area
    {
        double Compute(double x);
    }

    class Square : Area
    {
        public double Compute(double x)
        {
            return (x * x);
        }
    }

    class Circle : Area
    {
        public double Compute(double x)
        {
            return (Math.PI * x * x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square sqr = new Square();
            Circle cr = new Circle();

            Area area = (Area)sqr;
            Console.WriteLine("Area of Square = " + area.Compute(10));

            area = (Area)cr;
            Console.WriteLine("Area of Circle = " + area.Compute(10));

            Console.ReadLine();
        }
    }
}

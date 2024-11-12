using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class Area
    {
        public enum Shape
        {
            Circle,
            Square
        }

        public void Areashape(int x, Shape shape)
        {
            double area;
            switch (shape)
            {
                case Shape.Circle:
                    area = Math.PI * x * x;
                    Console.WriteLine("Circle area = " + area);
                    break;
                case Shape.Square:
                    area = x * x;
                    Console.WriteLine("Square area = " + area);
                    break;
                default:
                    Console.WriteLine("Invalid shape type.");
                    break;
            }
        }
    }

    class EnumTest
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            area.Areashape(15, Area.Shape.Circle);
            area.Areashape(15, Area.Shape.Square);
            area.Areashape(15, (Area.Shape)1);
            area.Areashape(15, (Area.Shape)10); // This will trigger the "Invalid shape type" message
            Console.ReadLine();
        }
    }
}

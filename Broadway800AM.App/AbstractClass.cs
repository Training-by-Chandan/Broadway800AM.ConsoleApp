using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public abstract class ShapeAbs // no object is created
    {
        public double area;
        public double perimeter;

        public void Area()
        {
            Console.WriteLine($"Area is {area}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter is {perimeter}");
        }

        public abstract void GetInput();
    }

    public class SquareAbs : ShapeAbs
    {
        private double length;

        public override void GetInput()
        {
            Console.WriteLine("Enter the length of square");
            length = Convert.ToDouble(Console.ReadLine());
            area = Math.Pow(length, 2);
            perimeter = 4 * length;
        }
    }

    public class RectangleAbs : ShapeAbs
    {
        private double length;
        private double breadth;

        public override void GetInput()
        {
            Console.WriteLine("Enter the length of rectangle");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the breadth of rectangle");
            breadth = Convert.ToDouble(Console.ReadLine());

            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
    }

    public class CircleAbs : ShapeAbs
    {
        private double radius;

        public override void GetInput()
        {
            Console.WriteLine("Enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radius, 2);
            perimeter = 2 * Math.PI * radius;
        }
    }
}
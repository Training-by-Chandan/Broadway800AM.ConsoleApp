using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public interface IShapesOperation
    {
        //int i { get; set; } //properties
        void Area();

        void Perimeter();
    }

    public interface IGetInput
    {
        void GetInput();
    }

    public interface IShape : IShapesOperation, IGetInput
    {
    }

    public class Square : IShape
    {
        private double length;

        public void Area()
        {
            Console.WriteLine($"Area = {Math.Pow(length, 2)}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the length of square");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter = {4 * length}");
        }

        public void Test()
        {
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        public double breadth;

        public void Area()
        {
            Console.WriteLine($"Area = {length * breadth}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the length of rectangle");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the breadth of rectangle");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter = {2 * (length + breadth)}");
        }
    }

    public class EquilateralTriangle : IShape
    {
        private double side;

        public void Area()
        {
            var area = (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
            Console.WriteLine($"Area is {area}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the side of equilateral  triangle");
            side = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of equilateral  triangle is {3 * side}");
        }
    }
}
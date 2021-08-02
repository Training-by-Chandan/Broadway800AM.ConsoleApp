using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public delegate void NumberDelegate(int a, int b);

    public class Delegs
    {
        public event NumberDelegate DoOperation;

        public Delegs()
        {
            DoOperation += Add;
            DoOperation += Subtract;
        }

        public void RaiseEvent(int a, int b)
        {
            DoOperation?.Invoke(a, b);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference = {a - b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Product = {a * b}");
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine($"Quotient = {x / y}");
        }

        public void DelegateImplementation()
        {
            var T = new NumberDelegate(Add);
            T(5, 4);
            T += Subtract;
            T(5, 4);
            T += Multiply;
            T(5, 4);
            T += Divide;
            T(5, 4);
            T -= Subtract;
            T -= Multiply;
            T -= Divide;
            T += ((int x, int y) =>
            {
                Console.WriteLine($"Testing x={x} and y={y}");
            });
            T(5, 4);

            Func<int, int, string> add = Sum;
            var res = add(10, 20);
        }

        private string Sum(int a, int b)
        {
            return (a + b).ToString();
        }
    }
}
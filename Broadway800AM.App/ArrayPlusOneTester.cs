using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public class ArrayPlusOneTester
    {
        private int[] input;

        public void GetInput()
        {
            Console.WriteLine("Enter the sequence");
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        public void Calculate()
        {
            int count = 0;
            foreach (var item in input)
            {
                var exist = input.Contains(item + 1);
                if (exist)
                {
                    count++;
                }
            }
            Console.WriteLine($"Total Count is {count}");
        }
    }
}
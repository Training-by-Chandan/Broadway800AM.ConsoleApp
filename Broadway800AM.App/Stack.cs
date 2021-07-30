using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    //for string data type
    //container  - Array of 5 elements
    //counter - int
    //Function to push
    //function to pop
    //function to display current members
    public class CustomStack
    {
        public CustomStack()
        {
            container = new string[5];
            this.maxSize = 5;
        }

        public CustomStack(int maxSize)
        {
            container = new string[maxSize];
            this.maxSize = maxSize;
        }

        private int maxSize;
        private string[] container;
        private int currentIndex = -1;

        public void Push(string item)
        {
            if (currentIndex < this.maxSize - 1)
            {
                currentIndex++;
                container[currentIndex] = item;
            }
        }

        public void Pop()
        {
            if (currentIndex >= 0)
            {
                container[currentIndex] = null;
                currentIndex--;
            }
        }

        public void DisplayAllItems()
        {
            for (int i = currentIndex; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
        }
    }

    public class CustomDynamicStack
    {
        private string[] container = new string[0];

        public void Push(string item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        public void Pop()
        {
            Array.Resize(ref container, container.Length - 1);
        }

        public void DisplayAllItems()
        {
            for (int i = container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
        }
    }

    public class CustomDynamicStackGeneric<T> where T : IShapesOperation
    {
        private T[] container = new T[0];

        public void Push(T item)
        {
            Array.Resize(ref container, container.Length + 1);
            container[container.Length - 1] = item;
        }

        public void Pop()
        {
            Array.Resize(ref container, container.Length - 1);
        }

        public void DisplayAllItems()
        {
            for (int i = container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
        }
    }

    public struct newStruct
    {
        public int i;
        public string j;
        public char k;
    }

    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class GenericOne<T1, T2>
        where T1 : struct
        where T2 : IShapesOperation
    {
        public T1 Variable1;
        public T2 Variable2;

        public void FunctionOne(T1 item1, T2 item2)
        {
            Console.WriteLine($"Type of item1={item1.GetType()}");
            Console.WriteLine($"Type of item2={item2.GetType()}");
        }
    }

    public class GenericTwo
    {
        public void FunctionOne<T1, T2>(T1 item1, T2 item2, T1 item3)
            where T1 : class
            where T2 : struct
        {
            Console.WriteLine($"Type of item1={item1.GetType()}");
            Console.WriteLine($"Type of item2={item2.GetType()}");
            Console.WriteLine($"Type of item3={item3.GetType()}");
        }
    }
}
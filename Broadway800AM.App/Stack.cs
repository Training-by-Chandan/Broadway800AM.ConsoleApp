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

    public class CustomDynamicStackGeneric<T>
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

    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}
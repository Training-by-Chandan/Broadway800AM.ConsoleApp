using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public class BasketBallGame
    {
        private string[] input;

        public void GetInput()
        {
            Console.WriteLine("Enter the Sequence");// 5 2 C 4 D +
            input = Console.ReadLine().Split(' ');
        }

        public void Calculate()
        {
            Stack<int> st = new Stack<int>();
            foreach (var item in input)
            {
                int num = 0;
                int.TryParse(item, out num);
                if (num != 0)
                {
                    st.Push(num);
                }
                else if (item == "C")
                {
                    st.Pop();
                }
                else if (item == "D")
                {
                    var prev = st.Peek();
                    st.Push(prev * 2);
                }
                else if (item == "+")
                {
                    var poped = st.Pop();
                    var peeked = st.Peek();
                    st.Push(poped);
                    st.Push(poped + peeked);
                }
            }

            Console.WriteLine($"Output is {st.Sum()}");
        }
    }
}
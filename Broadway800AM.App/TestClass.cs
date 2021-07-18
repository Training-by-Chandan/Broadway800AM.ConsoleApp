using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App.Test
{
    public class TestClass
    {
        public static void PublicTest()
        {
        }

        private static void PrivateTest()
        {
        }
    }

    //Variables
    //Methods
    //Properties
    //Constructor
    //Destructors(X) Dispose => Garbage Collector (GC)
    public class NewClass
    {
        public int i;
        public string j;
        public int k = 20;

        //constructor overloading
        //blank Constructor

        //same name as that of Class
        //no return
        public NewClass() // parameterless constructor
        {
            this.i = 10;
            this.j = "Default";
        }

        public NewClass(int i) // paratemerized constructot
        {
            this.i = i; //this => mero
            this.j = "Default";
        }

        public NewClass(string j)
        {
            this.j = j;
            i = 10;
        }

        public NewClass(int i, string j)
        {
            this.i = i; //this
            this.j = j + " First";
        }

        public NewClass(string j, int i)
        {
            this.j = j + " Second";
            this.i = i;
        }

        public void Function1()
        {
        }

        public void Function1(int i)
        {
        }

        public void Function1(string j)
        {
        }

        //operator overloading
        public static NewClass operator +(NewClass obj1, NewClass obj2)
        {
            var res = new NewClass();
            res.i = obj1.i + obj2.i;
            res.j = obj1.j + "." + obj2.j;
            res.k = obj1.k + obj2.k;

            return res;
        }

        public static NewClass operator ++(NewClass obj1)
        {
            var res = new NewClass();
            res.i = obj1.i + 1;
            res.j = obj1.j + "-";
            res.k = obj1.k + 1;
            return res;
        }
    }
}
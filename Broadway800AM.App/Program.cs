//using directive
using System;
using Broadway800AM.App.Test;

//namespace
namespace Broadway800AM.App
{
    //class interfaces and other things
    //access modifers : public, private, protected, internal, and internal protected

    public class Program
    {
        //methods and properties and other things
        //entry point of project
        //static method
        private static void Main(string[] args)
        {
            DataTypeAndConversionExample();

            Console.ReadLine();
        }

        private static void DataTypeAndConversionExample()
        {
            char character = 'A';
            string str = "This is test string";
            int numbera = 10;
            long numberlong = 10;
            float smallfloating = 10.02F;
            double doubleNumber = 10.25D;

            //conversion / Casting
            //3 process
            //1. Implicit Casting
            //2. Explicit Casting
            //3. TypeConversion Convert Class

            //1. Implicit Casting // automatic casting
            // char < int < long < float < double
            char a = 'W';
            int b = a;
            long c = b;
            float d = c;
            double e = d;

            //2. Explicit Casting // manual casting
            double z = 10.10;
            float y = (float)z;
            long x = (long)y;
            int w = (int)x;
            char v = (char)w;

            //3. Typeconversion Convert Class
            string str1 = "10";
            //int strNum = (int)str1; // not possible
            int strNum = Convert.ToInt32(str1);
            int strNum1 = Convert.ToInt32(z);

            string test = strNum1.ToString();

            var testvar = "10";
            testvar = "";

            object obj = "10";
            obj = 10;
            obj = 10f;

            //array
            int[] i = new int[10];
            i[0] = 10;
            i[1] = 'A'; //possible due to implicit casting
            i[2] = (int)10d; // possible due to explicit casting
            i[3] = Convert.ToInt32("10"); // possible due to Convert Class
        }
    }
}
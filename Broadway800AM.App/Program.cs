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
            var res = "n";
            do
            {
                //DataTypeAndConversionExample();

                ControlStatementExample();

                Console.WriteLine("Do you want to continue more(y/n)?");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }

        private static void ControlStatementExample()
        {
            //if else
            Console.WriteLine("Enter Any Number:");

            var num = Convert.ToInt32(Console.ReadLine());
            string str = "";

            // == equals, != not equals, >= greather than equal to, <= less than equals to, > greater than, < less than
            if (num == 1)
                str = "One";
            else if (num == 2)
                str = "Two";
            else
                str = "Thaha chaina";

            // (condition) ? <True statement> : false statement
            string strnew = num == 1 ? "One" : num == 2 ? "Two" : "Thaha chaina";

            Console.WriteLine("Enter The Number of Day:");
            var daysnum = Convert.ToInt32(Console.ReadLine());
            string daystr = "";
            switch (daysnum)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.Write("No Day");
                    break;
            }

            switch (daysnum)
            {
                case 1:
                case 7:
                    Console.WriteLine("Its a weekend! Enjoy!");
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Its a weekdays! Enjoy your work!");
                    break;

                default:
                    break;
            }
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
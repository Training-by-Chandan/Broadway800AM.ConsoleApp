//using directive
using System;
using Broadway800AM.App.Test;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

                //ControlStatementExample();

                //LoopingStatementExample();

                //OperatorOverloadingExample();

                //InheritanceExample();

                //PolyMorphismExample();

                //InterfaceExample();

                //PropertiesExample();

                //StaticAndNonStaticExample();

                //AbstractExample();

                //StackExample();

                //DynamicStackExample();

                //CustomStackGenericExample();

                //CollectionExamples();

                PassByExample();

                Console.WriteLine("Do you want to continue more(y/n)?");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }

        private static void PassByExample()
        {
            int a = 10;
            int b = 20;
            PassBy.ByValue(a, b);
            Console.WriteLine($"Using By Value a={a}, b={b}");

            PassBy.ByReference(ref a, ref b);
            Console.WriteLine($"Using By reference a={a}, b={b}");

            PassBy.ByValue(a, b);
            Console.WriteLine($"Using By Value a={a}, b={b}");

            PassBy.ByReference(ref a, ref b);
            Console.WriteLine($"Using By reference a={a}, b={b}");
            int res = 0;

            PassBy.ByValueInOut(a, b, out a);
            Console.WriteLine($"Using By Out a={a}, b={b}, res={res}");

            PassBy bp = new PassBy();
            var name = PassBy.Name;// name is not accessible from object

            var newname = bp.NewName;
            var getname = bp.GetName;
        }

        private static void CollectionExamples()
        {
            //non generic => System.Collections

            Stack st = new Stack();
            st.Push(10);
            st.Push("");

            List<string> list = new List<string>();
            list.Add("");

            var listnew = new List<object>();
            listnew.Add(10);
            listnew.Add("");
            var item1 = listnew[0];
            var listarr = listnew.ToArray();
            var newlist = new List<object>(listarr);

            List<string> days = new List<string> { "Sun", "Sunday", "Mon", "Monday", "Tue", "Tuesday", "Wed", "Wednesday", "Thu", "Thursday", "Fri", "Friday", "Sat", "Saturday", "Sun", "Sunday", "Mon", "Monday", "Tue", "Tuesday", "Wed", "Wednesday", "Thu", "Thursday", "Fri", "Friday", "Sat", "Saturday", "Sun", "Sunday", "Mon", "Monday", "Tue", "Tuesday", "Wed", "Wednesday", "Thu", "Thursday", "Fri", "Friday", "Sat", "Saturday", "Sun", "Sunday", "Mon", "Monday", "Tue", "Tuesday", "Wed", "Wednesday", "Thu", "Thursday", "Fri", "Friday", "Sat", "Saturday", "Sun", "Sunday", "Mon", "Monday", "Tue", "Tuesday", "Wed", "Wednesday", "Thu", "Thursday", "Fri", "Friday", "Sat", "Saturday" };
            //days.Reverse();
            //var firstday = days[0];
            //days.Sort();
            //days.Reverse();
            //var totalitem = days.Count;

            days.Insert(2, "Chandan");
            var Sun = (from d in days where !d.Contains("day") select d.ToUpper()); //linq query (language integrated query)
            // select * from days where d.name='Sun'
            var name = GenerateDummyData();

            var filteredname = (from n in name where !n.Name.ToUpper().StartsWith("B") select n);
            var filterednamelambda = name.Where(n => !n.Name.ToUpper().StartsWith("B"));

            var orderedlist = (from k in name orderby k.Name select new { StudentName = k.Name, StudentEmail = k.Email, StudentId = k.id });
            var orderedListLambda = name.OrderBy(p => p.Name).Select(x => new { StudentName = x.Name, StudentEmail = x.Email });

            foreach (var item in orderedlist)
            {
                Console.WriteLine(item.StudentId);
            }
        }

        private static List<Student> GenerateDummyData()
        {
            var listoStudent = new List<Student>();
            listoStudent.Add(new Student { id = 1, Name = "Chandan", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 2, Name = "Kasturi", Email = "kasturi@gmail.com" });
            listoStudent.Add(new Student { id = 3, Name = "Bikash", Email = "bikash@gmail.com" });
            listoStudent.Add(new Student { id = 4, Name = "Bibek", Email = "Bibek@gmail.com" });
            listoStudent.Add(new Student { id = 5, Name = "Bijay", Email = "Bijay@gmail.com" });
            listoStudent.Add(new Student { id = 6, Name = "Saroj", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 7, Name = "Niroj", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 8, Name = "binita", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 9, Name = "Pratik", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 10, Name = "John", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 11, Name = "Charles", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 12, Name = "Tony", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 13, Name = "Steve", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 14, Name = "Nick", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 15, Name = "Barton", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 16, Name = "Natasha", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 17, Name = "Bucky", Email = "chandan@gmail.com" });

            return listoStudent;
        }

        private static void CustomStackGenericExample()
        {
            //CustomDynamicStackGeneric<int> csd1 = new CustomDynamicStackGeneric<int>();
            //csd1.Push(1);
            //CustomDynamicStackGeneric<newStruct> csd2 = new CustomDynamicStackGeneric<newStruct>();
            ////csd2.Push("One");

            //CustomDynamicStackGeneric<Student> csd3 = new CustomDynamicStackGeneric<Student>();
            //csd3.Push(new Student());

            //CustomDynamicStackGeneric<HumanBeing> csd4 = new CustomDynamicStackGeneric<HumanBeing>();
            //HumanBeing h1 = new Men();
            //csd4.Push(h1);

            CustomDynamicStackGeneric<Square> csd5 = new CustomDynamicStackGeneric<Square>();
            //GenericOne<string, Square> genericOne = new GenericOne<string, Square>();
            //genericOne.FunctionOne("", new Square());
            //GenericOne<Square, string> genericTwo = new GenericOne<Square, string>();
            //genericTwo.FunctionOne(new Square(), "");
            GenericOne<int, Square> g1 = new GenericOne<int, Square>();
            GenericTwo g2 = new GenericTwo();
            g2.FunctionOne<string, int>("", 10, "");
        }

        private static void DynamicStackExample()
        {
            CustomDynamicStack cs = new CustomDynamicStack();
            Console.WriteLine("After pushing one, two three, four");
            cs.Push("One");
            cs.Push("Two");
            cs.Push("Three");
            cs.Push("Four");
            cs.DisplayAllItems();
            Console.WriteLine("After popping 3 times");
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.DisplayAllItems();
            Console.WriteLine("After pushing Five, six, seven, eight, nine");
            cs.Push("Five");
            cs.Push("Six");
            cs.Push("Seven");
            cs.Push("Eight");
            cs.Push("Nine");
            cs.Push("Ten");
            cs.Push("Eleven");
            cs.Push("Twelve");
            cs.DisplayAllItems();
        }

        private static void StackExample()
        {
            CustomStack cs = new CustomStack(100);
            Console.WriteLine("After pushing one, two three, four");
            cs.Push("One");
            cs.Push("Two");
            cs.Push("Three");
            cs.Push("Four");
            cs.DisplayAllItems();
            Console.WriteLine("After popping 3 times");
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.DisplayAllItems();
            Console.WriteLine("After pushing Five, six, seven, eight, nine");
            cs.Push("Five");
            cs.Push("Six");
            cs.Push("Seven");
            cs.Push("Eight");
            cs.Push("Nine");
            cs.DisplayAllItems();
        }

        private static void AbstractExample()
        {
            Console.WriteLine("Press 1 for square abs\nPress 2 for rectangle abs\nPress 3 for circle abs");
            var choice = Convert.ToInt32(Console.ReadLine());
            var shape = GetShapeAbs(choice);
            //var s = new ShapeAbs(); //object cannot be created for abstract class
            if (shape != null)
            {
                shape.GetInput();
                shape.Perimeter();
                shape.Area();
            }
        }

        private static ShapeAbs GetShapeAbs(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new SquareAbs();

                case 2:
                    return new RectangleAbs();

                case 3:
                    return new CircleAbs();

                default:
                    return null;
                    break;
            }
        }

        private static void StaticAndNonStaticExample()
        {
            //StaticClass st = new StaticClass(); // this is not possible
            StaticClass.i = 20;
            StaticClass.FirstName = "Kasturi";
            StaticClass.FunctionOne();

            NonStaticClass Obj1 = new NonStaticClass();
            Obj1.ObjectName = "Object One";
            NonStaticClass Obj2 = new NonStaticClass();
            Obj2.ObjectName = "Object Two";
            NonStaticClass Obj3 = new NonStaticClass();
            Obj3.ObjectName = "Object Three";
            NonStaticClass Obj4 = new NonStaticClass();
            Obj4.ObjectName = "Object Four";

            Obj1.AddByOne();
            Obj2.AddByOne();
            NonStaticClass.i = 30;
            Obj3.AddByOne();
            Obj4.AddByOne();
        }

        private static void PropertiesExample()
        {
            TestClass t = new TestClass("Chandan", "Kumar", "Bhagat");

            Console.WriteLine("Enter the Math Marks");
            t.MathMarks = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(t.FullName + "\nMath Marks => " + t.MathMarks);
        }

        private static void InterfaceExample()
        {
            Console.WriteLine("Press 1 for Square\nPress 2 for Rectangle\npress 3 for equilateral triangle");
            var choice = Convert.ToInt32(Console.ReadLine());

            var s = GetShape(choice);

            s.GetInput();
            s.Perimeter();
            s.Area();
        }

        private static IShape GetShape(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Square();
                    break;

                case 2:
                    return new Rectangle();
                    break;

                case 3:
                    return new EquilateralTriangle();
                    break;

                default:
                    return null;
                    break;
            }
        }

        private static void PolyMorphismExample()
        {
            LivingThings l1 = new LivingThings(20);
            Animal a1 = new Animal();
            Plant p1 = new Plant();
            //LivingThings h1 = new HumanBeing();
            //LivingThings m1 = new Men();
            //LivingThings w1 = new Women();

            l1.Eat();
            a1.Eat();
            p1.Eat();

            l1 = a1;
            l1.Eat();

            //h1.Eat();
            //m1.Eat();
            //w1.Eat();

            //Console.WriteLine();
            //l1.Reproduce();
            //Console.WriteLine();
            //a1.Reproduce();
            //Console.WriteLine();
            //h1.Reproduce();
        }

        private static void InheritanceExample()
        {
            //LivingThings l1 = new LivingThings();
            LivingThings l2 = new LivingThings(20);

            Animal a1 = new Animal();
            Animal a2 = new Animal(20);

            Plant p1 = new Plant();
            HumanBeing h1 = new HumanBeing();
            Men m1 = new Men();
            Women w1 = new Women();

            //l1.Eat();
            //l1.Reproduce();
            //l1.FunctionTest();
            //l1.Respire();
            //l1.Test();

            a1.Eat();
            a1.Reproduce();
            a1.FunctionTest();
            a1.Test();
            //a1.Respire();

            p1.Eat();
            p1.Reproduce();
            //p1.Respire();
        }

        private static void OperatorOverloadingExample()
        {
            int i = 10;
            int j = 7;
            var sum = i + j;
            i++;

            NewClass c1 = new NewClass(5);
            NewClass c2 = new NewClass(5, "");

            NewClass c3 = new NewClass(4);
            NewClass c4 = new NewClass(3);
            NewClass c5 = new NewClass("", 4);
            NewClass c6 = new NewClass();
            NewClass c7 = new NewClass("");

            var sumofClass = new NewClass();
            sumofClass.i = c1.i + c2.i + c3.i;
            sumofClass.j = c1.j + " " + c2.j + " " + c3.j;
            sumofClass.k = c1.k + c2.k + c3.k;

            var resSum = c1 + c2 + c3 + c4 + c5 + c6 + c7;
            c1++;
            c1++;
        }

        private static void ClassExample()
        {
            NewClass c1 = new NewClass(5);
            NewClass c2 = new NewClass(5, "");
            NewClass c3 = new NewClass(4);
            NewClass c4 = new NewClass(3);
            NewClass c5 = new NewClass("", 4);
            NewClass c6 = new NewClass();
            NewClass c7 = new NewClass("");

            c1.Function1();
            c1.Function1(11);
        }

        private static void LoopingStatementExample()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 3 || i == 5)
                    continue;
                if (i == 10)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter any string");
            string str = Console.ReadLine(); ;
            foreach (var j in str)
            {
                Console.WriteLine(j);
            }

            float[] test = new float[] { 1.54f, 2f, 3, 4, 2555.225f, 6, 7, 8 };
            float sum = 0;
            foreach (var t in test)
            {
                sum += t;
                Console.WriteLine(sum);
            }
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
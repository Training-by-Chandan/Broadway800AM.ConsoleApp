using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public class PassBy
    {
        public const string Name = "Chandan";
        public readonly string NewName = "Chandan";

        public string GetName
        {
            get { return "Chandan"; }
        }

        public PassBy()
        {
            //Name = "Bikash";
            NewName = "Kasturi";
            //GetName = "";
        }

        public static void ByValue(int a, int b)
        {
            a = a + b;
            b++;
        }

        public static void ByReference(ref int a, ref int b)
        {
            a = a + b;
            b++;
        }

        public static void ByValueInOut(int a, int b, out int x)
        {
            x = a + b;
            b++;
            a++;
        }

        public void ChangeNames()
        {
            //Name = "Bikash";
            //NewName = "Kasturi";
            //GetName = "";
        }
    }
}
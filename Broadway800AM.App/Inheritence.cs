using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public class LivingThings
    {
        public LivingThings(int i)
        {
            this.i = i;
        }

        private int i;

        protected void Respire()
        {
            Console.WriteLine("Living thing can respire");
        }

        public void Eat()
        {
            Console.WriteLine("Living thing can Eat");
        }

        public void Reproduce()
        {
            Console.WriteLine("Living thing can reproduce");
        }

        public void FunctionTest()
        {
            int i = 40;
            Respire();
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base(30)
        {
        }

        public Animal(int i) : base(i)
        {
        }

        public void Test()
        {
            Respire();
        }
    }

    public class Plant : LivingThings
    {
        public Plant() : base(30)
        {
        }

        public Plant(int x) : base(x)
        {
        }
    }

    public class HumanBeing : Animal
    {
        public HumanBeing()
        {
        }
    }

    public class Men : HumanBeing
    {
        public Men()
        {
        }
    }

    public class Women : HumanBeing
    {
        public Women()
        {
        }
    }
}
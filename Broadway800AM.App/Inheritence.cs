using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    /// <summary>
    /// Inheritance class
    /// </summary>
    public class LivingThings
    {
        public LivingThings(int i)
        {
            this.i = i;
        }

        protected int i;

        protected void Respire()
        {
            Console.WriteLine("Living thing can respire");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Living thing can Eat");
        }

        public virtual void Reproduce()
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

        public override void Eat()
        {
            Console.WriteLine("Animal can Eat");
        }

        public void Test()
        {
            Respire();
        }

        public override void Reproduce()
        {
            Console.WriteLine("Animal can reproduce");
            base.Reproduce();
        }
    }

    public sealed class Plant : LivingThings
    {
        public Plant() : base(30)
        {
        }

        public Plant(int x) : base(x)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Plant can Eat");
        }
    }

    public class HumanBeing : Animal
    {
        public HumanBeing()
        {
        }

        public void Eat()
        {
            Console.WriteLine("Human Being can Eat");
        }

        public override void Reproduce()
        {
            Console.WriteLine("Human can reproduce");
            base.Reproduce();
        }
    }

    public class Men : HumanBeing
    {
        public Men()
        {
        }

        public void Eat()
        {
            Console.WriteLine("Men can Eat");
        }
    }

    public class Women : HumanBeing
    {
        public Women()
        {
        }

        public void Eat()
        {
            Console.WriteLine("Women can Eat");
        }
    }

    //public class SomeExtra : Plant, Animal // one class can inherit only one class
    //{
    //}
}
using System;

namespace _07.TypeCasting
{
    class TypeCasting
    {
        // static void Main(string[] args)
        // {
        //     Mammal mammal = new Dog();
        //     Dog dog;

        //     if (mammal is Dog)
        //     {
        //         dog = (Dog)mammal;
        //         dog.Bark();

        //     }

        //     Mammal mammal2 = new Cat();

        //     Cat cat = mammal2 as Cat;
        //     if (cat != null)
        //     {
        //         cat.Meow();
        //     }

        //     Cat cat2 = mammal as Cat;
        //     if (cat2 != null)
        //         cat2.Meow();
        //     else
        //         Console.WriteLine("cat2 is not a Cat");
        // }
        
         static void Main3(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite IronMan = new IronMan();
            IronMan.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
          
        }
    }

    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal{
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }


    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite{
        public override void Initialize(){
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");

        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Laouncher Armed");
        }
    }
}


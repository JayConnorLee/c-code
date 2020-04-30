using System;

namespace _07.MethodHiding
{
   
    class MainApp
    {
         static void Main2(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }

    class Base
    {
        // public void MyMethod()
        public virtual void MyMethod()
        {
            Console.WriteLine("Base.WyMethod()");

        }

    }

    class Derived : Base
    {
        // public new void MyMethod()
        public override void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

}


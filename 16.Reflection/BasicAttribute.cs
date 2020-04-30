using System;
using System.Reflection;

namespace _16.Reflection
{
    class MyClass
    {
        [Obsolete("OldMethod has been deprecated. use the NewMethod()")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }

    class BasicAttribute
    {

        static void Main2(string[] args)
        {
                MyClass obj = new MyClass();

                obj.OldMethod();
                obj.NewMethod();
        }

    }
 
}

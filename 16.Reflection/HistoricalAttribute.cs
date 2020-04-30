using System;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace _16.Reflection
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple=true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Sean", version = 0.1, changes = "2017-11-01 Created class stub")]
    [History("Bob", version = 0.2, changes = "2017-12-03 Added Func() Method")]
    class MyClass2
    {
        public void Func()
        {
        }
    }

        

    
    class HistoricalAttribute
    {
   

        static void Main2(string[] args)
        {
            Type type = typeof(MyClass2);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("MyClass change history...");

            foreach (Attribute a in attributes)
            {
                History h = a as History;
                if (h != null)
                    Console.WriteLine("Ver:{0}, Programmer:{1}, Chanegs:{2}", h.version, h.GetProgrammer(), h.changes);
            }

        }
    }

}

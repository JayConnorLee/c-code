using System;
using System.Reflection;

namespace _16.Reflection
{
    class GetType
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("-------- Interfaces --------");

            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
                Console.WriteLine("Name:{0}", i.Name);

            Console.WriteLine();

        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("----- Fields ------");

            FieldInfo[] fields = type.GetFields(
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Static |
                System.Reflection.BindingFlags.Instance 
            );

            foreach (FieldInfo field in fields)
            {
                String accessLevel = "proteceted";
                if ( field.IsPublic) accessLevel = "public";
                else if( field.IsPrivate) accessLevel = "private";

                Console.WriteLine("Access:{0}, Type:{1}, Name:{2}", accessLevel, field.FieldType.Name, field.Name);

            }

            Console.WriteLine();

        }
        static void PrintContructors(Type type)
        {
            Console.WriteLine("---------- Contructors ---------");

            ConstructorInfo[] conInfos = type.GetConstructors();
            foreach (ConstructorInfo conInfo in conInfos)
            {
                Console.Write("type:{0}, name:{1}, Parameter :", conInfo.Name, 1);
            }
            Console.WriteLine();
        }

        static void PrintMethods(Type type)
        {
            Console.WriteLine("------- Methods ----------");

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.Write("Type:{0}, Name:{1}, Parameter:", method.ReturnType.Name, method.Name);

                ParameterInfo[] args = method.GetParameters();
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write("{0}", args[i].ParameterType.Name);
                    if(i < args.Length -1)
                        Console.Write(", ");

                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }

        static void PrintProperties(Type type)
        {
            Console.WriteLine("-------- Properties --------- ");

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
                Console.WriteLine("Type:{0}, Name:{1}", property.PropertyType.Name, property.Name);
            
            Console.WriteLine();

        }

        static void Main2(string[] args)
        {
            int a = 0;
            testClass tt = new testClass("Main2");

            Type type = a.GetType();
                type = tt.GetType();

            PrintContructors(type);
            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);
        }
    }
    class testClass
    {
        private string str;
        private int iPtr;

        public testClass(string str)
        {
            this.str = str;
        }

        void testMethod()
        {
            int i = this.iPtr;
        }

        int testIntmethod()
        {
            int i = this.iPtr;
            return  i;
        }
        
    }
}

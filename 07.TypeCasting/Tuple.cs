using System;
using System.Collections.Generic;

namespace _07.Tuple
{
    class Tuple
    {
        static void Main(string[] args)
        {
            var a = ("superMan", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            var b = (Name: "Con", Age: 20);
            Console.WriteLine($"{b.Name}, {b.Age}");

            var (name, age) = b;
            Console.WriteLine($"{name}, {age}");

            b = a;
            Console.WriteLine("${b.Name}, {b.Age}");
        }
    }
}


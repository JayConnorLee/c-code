using System;

namespace _14.Lambda
{
    class SimpleLambda
    {
        delegate int Calculate(int a, int b);

        static void Main2(string[] args)
        {
            Calculate calc = (a, b) => a + b;
            Console.WriteLine($"{3} + {4} : {calc(3,4)}");
        }
    }
}

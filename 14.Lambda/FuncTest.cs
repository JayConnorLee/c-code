using System;

namespace _14.Lambda
{
    class FuncTest
    {
        static void Main2(string[] args)
        {
            Func<int> func1 = () => 10;
            Console.WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"func2(3) : {func2(3)}");

            Func<double, double, double> func3 = (x,y) => x / y;
            Console.WriteLine($"func3(6,3) : {func3(6,3)}");
     
        
        }
    }
}

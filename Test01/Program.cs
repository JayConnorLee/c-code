using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 2;
            
            
            Console.WriteLine( a.Power(3));
            Console.WriteLine(10.Power(4));

            string s;
            s = "Where do you live, do you live alone".DoubleQuote();
            s = s.DoubleQuote();

            Console.WriteLine(s);


        }
    }

    public static class IntegerExtension{
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i< exponent; i++)
                result = result * myInt;

            return result;

        }
        
        public static string DoubleQuote(this string sChar)
        {
            string s = '"' + sChar + '"';
            return s;
        }

    }
}

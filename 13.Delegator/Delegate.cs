using System;

namespace _13.Delegator
{
    delegate int MyDelegate(int a , int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;

        }


        public static int Minus(int a, int b)
        {
            return a - b;

        }


    }
    class Delegate1
    {

        static void Main2(string[] args)
        {


                Console.WriteLine("Task has been started");
                Calculator Calc = new Calculator();
                MyDelegate Callback;

                Callback = new MyDelegate( Calc.Plus);
                Console.WriteLine(Callback(3,4));

                Callback = new MyDelegate(Calculator.Minus);
                Console.WriteLine(Callback(7,5));


            
        }
    }
}

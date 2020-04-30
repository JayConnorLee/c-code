using System;

namespace _13.Delegator
{
    
    delegate void EventHandler(string message);
    delegate void aaa();
    class MyNotifier
    {
        private int testInt;
        public event EventHandler SomethingHappened;
        
        // public event aaa bbb;
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : Even", number));
            }
        }
    }


    class EventTest{ 

        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifer = new MyNotifier();
            notifer.SomethingHappened += new EventHandler(MyHandler);

            for (int j = 0; j < 30; j++)
            {
                notifer.DoSomething(j);
            }
        }
    }
}


using System;

namespace _13.Delegator
{
    delegate void Notify(string message);
    
    class Notifier
    {
            public Notify EventOccured;

    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;

        }

        
        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }

        public void thereIsNothing(string message)
        {
            Console.WriteLine($"{name}.thereIsNothing : {message}");
        }
    }

    class DelegateChain{

        static void Main2(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("listener1");
            EventListener listener2 = new EventListener("listener2");
            EventListener listener3 = new EventListener("listener3");
            
            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail.");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Downlead complete.");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend)
                                + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Unclear launch detected.");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);
            Notify notify3 = new Notify(listener1.thereIsNothing);
            

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2, notify3);
            notifier.EventOccured("Fired");


            Console.WriteLine();


            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG!");




        }
    }
}


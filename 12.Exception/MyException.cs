using System;

namespace _12.MyException
{

    class InvalidArgumentException : Exception 
    {
        public InvalidArgumentException() 
        {

        }

        public InvalidArgumentException(string message) : base(message)
        {

        }

        public object Argument 
        {
            get; set;
        }

        public string Range 
        { get; set;}

    }

    
    class MyException
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint [] args = new uint[] {alpha, red, green, blue};

            foreach (uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException() 
                    {
                        Argument = arg,
                        Range = "0-255"
                    };
            }
        }

    }
    

}

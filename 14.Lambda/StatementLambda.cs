using System;

namespace _14.Lambda
{
    class StatementLambda
    {
        delegate string Concatenate(string[] args);


        static void Main2(string[] args)
        {

            Concatenate concat = (arr) => 
            {
                string result = "";
                foreach (string s in arr)
                    result += s;
                
                return result;
            };

            string[] arr = {"1", "2"};
            Console.WriteLine(concat(arr));

            Concatenate concat2 = (arr2) =>
            {
                string result = "";
                foreach (string s in arr2)
                    result += s;
                
                return result;
            };
        
        }
    }
}

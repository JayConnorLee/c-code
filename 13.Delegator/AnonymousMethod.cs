using System;

namespace _13.Delegator
{
    //private delegate int Compare(int a, int b);


    class AnonymousMethod{

        static void BubbleSort(ref int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for ( j = 0; j < DataSet.Length - ( i + 1); i++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
                
            }
        }
        static void Main2(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(ref array, delegate(int a, int b)
            {
                if (a > b)
                    return 1;
                
                else if (a == b)
                    return 0;
                
                else
                    return -1;
                
            });

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]}");
            
            int[] array2 = {7, 2, 8, 10, 11};
            Console.WriteLine("\nSorting descending..");

            BubbleSort(ref array2, delegate(int a, int b)
            {
                if (a<b)
                    return 1;
                else if (a ==b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]}");

            Console.WriteLine();

            BubbleSort(ref array2, delegate(int a, int b){
                return 1;

            });
            


            
        }
    }
}


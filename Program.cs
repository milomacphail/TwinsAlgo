using System;

namespace Twins
{

    class IntegerArray
    {
        int Min = -1000;
        int Max = 1000;
        Random random = new Random();


        public int[] ArrayFiller(int x)
        {
            int[] testArray = new int[x];

            for (int i = 0; i < testArray.Length; i++)
            {
                random.Next(Min, Max);
            }
            return testArray;
        }
        
        public static void FindPairs(int[] arrayToPair, int sum)
        {
            int pairCount = 0;

            for (int i = 0; i < arrayToPair.Length; i++)
            {
                for (int j = i + 1; j < arrayToPair.Length; j++)
                {
                    if(arrayToPair[i] + arrayToPair[j] == sum)
                    {
                        pairCount++;
                    }
                }
            }
            Console.WriteLine(pairCount);
        }

 
        class Program
        {
            static void Main(string[] args)
            {
                IntegerArray newArray = new IntegerArray();
                
            }
        }
    }
}

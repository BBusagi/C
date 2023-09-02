using System;

namespace project001
{
    class project001_MaxSubarray_1
    {
        static void Main(string[] args)
        {
            int[] priceArray = new int[] { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int[] priceFlu = new int[priceArray.Length - 1];
            for (int i = 1; i < priceArray.Length; i++)
            {
                priceFlu[i - 1] = priceArray[i] - priceArray[i-1];
            }
            
            Console.WriteLine(string.Join(" ", priceFlu));

            int maxSum = priceFlu[0];
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < priceFlu.Length; i++)
            {
                for (int j = i; j < priceFlu.Length; j++)
                {
                    int tempSum = 0;
                    for (int index = i; index < j + 1; index++)
                    {
                        tempSum += priceFlu[index];
                    }
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        minIndex = i;
                        maxIndex = j;
                    }
                }
            }

            Console.WriteLine(minIndex+ ":" +maxIndex); ;
            Console.WriteLine("from "+ minIndex + " to " + (maxIndex+1));

        }
    }
}

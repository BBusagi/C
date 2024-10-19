using System;

namespace project002_MaxSubarray_2
{
    class Program
    {
        struct SubArray
        {
            public int maxIndex;
            public int minIndex;
            public int sum;
        }

        static void Main(string[] args)
        {
            int[] priceArray = new int[] { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
            int[] priceFlu = new int[priceArray.Length - 1];
            for (int i = 1; i < priceArray.Length; i++)
            {
                priceFlu[i - 1] = priceArray[i] - priceArray[i - 1];
            }

            Console.WriteLine(string.Join(" ", priceFlu));
            SubArray subArray = GetMaxArr(0, priceFlu.Length - 1, priceFlu);
            Console.Write(subArray.minIndex+" : "+subArray.maxIndex);
            Console.WriteLine();
        }

        static SubArray GetMaxArr(int low, int high, int[] arr)
        {
            //递归结束条件，只有一个元素
            if (low == high)
            {
                SubArray subarr;
                subarr.minIndex = low;
                subarr.maxIndex = high;
                subarr.sum = arr[low];
                return subarr;
            }

            int mid = (low + high) / 2; //{low,mid} {mid+1,high}
            SubArray subArr1 = GetMaxArr(low, mid, arr);    //1. {low,mid} 1)
            SubArray subArr2 = GetMaxArr(mid + 1, high, arr);   //2. {mid+1,high}

            //3. 
            //3.1
            int sum1 = arr[mid];
            int minIndex = mid;
            int tempSum = 0;
            for (int i = mid; i >= low; i--)
            {
                tempSum += arr[i];
                if (tempSum > sum1)  
                { 
                    sum1 = tempSum;
                    minIndex = i;
                }
            }
             
            //3.2
            int sum2 = arr[mid + 1];
            int maxIndex = mid + 1;
            tempSum = 0;
            for (int j = mid + 1; j <= high; j++)
            {
                tempSum += arr[j];
                if (tempSum > sum2)
                {
                    sum2 = tempSum;
                    maxIndex = j;
                }
            }
            SubArray subArr3;
            subArr3.minIndex = minIndex;
            subArr3.maxIndex = maxIndex;
            subArr3.sum = sum1 + sum2;

            SubArray subArr;
            if (subArr1.sum >= subArr2.sum)
            {
                subArr = subArr1;
            }
            else { subArr = subArr2; }

            if (subArr3.sum > subArr2.sum)
            {
                subArr = subArr3;
            }

            return subArr;

        }
    }
}

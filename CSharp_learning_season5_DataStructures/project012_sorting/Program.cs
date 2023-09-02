using System;

namespace project012_sorting
{
    class Program
    {
        static void InsertSort(int[] dataArray)
        {
            for (int i = 1; i < dataArray.Length; i++)
            {
                int ivalue = dataArray[i];
                bool isInsert = false;
                for (int j = i - 1; j >= 0; j--)
                {

                    if (dataArray[j] > ivalue)
                    {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else 
                    {
                        dataArray[j + 1] = ivalue;
                        isInsert = true;
                        break;
                    }
                }
                if (isInsert == false)
                { 
                    dataArray[0] = ivalue;
                }
            }
        
        }

        static void SelectSort(int[] dataArray)
        {
            for (int i = 0; i < dataArray.Length; i++)
            {
                int min = dataArray[i];
                int minIndex = i;
                for (int j = i + 1; j < dataArray.Length; j++)
                {
                    if (dataArray[j] < min)
                    {
                        min = dataArray[j];
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
            }
        }

        static void QuickSort(int[] dataArray, int left, int right)
        {
            if (left < right)
            {
                int pivot = dataArray[left];
                int i = left;
                int j = right;

                while (true && i < j)
                {
                    //left -> right
                    while (true && i < j)
                    {
                        if (dataArray[j] <= pivot)
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }

                    //left <- right
                    while (true && i < j)
                    {
                        if (dataArray[i] > pivot)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                dataArray[i] = pivot;

                QuickSort(dataArray,left,i-1);
                QuickSort(dataArray,i+1,right);
            }
        }


        static void Main(string[] args)
        {
            //int[] data = new int[] { 3, 1, 2, 5, 7, 1, 6};
            int[] data = new int[] { 3, 1, 2};
            //int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17,48 };
            //InsertSort(data);
            //SelectSort(data);
            //QuickSort(data, 0, data.Length - 1);

            QuickSort_chatGPT quickSort2 = new QuickSort_chatGPT();
            quickSort2.QuickSort(data, 0, data.Length - 1);

            Console.WriteLine();
            foreach (var temp in data)
            {
                Console.Write(temp+"  ");
            }
            Console.WriteLine();
        }
    }
}

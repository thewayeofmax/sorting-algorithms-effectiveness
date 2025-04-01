using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_effectiveness
{
    public class SortingAlgorithms
    {

        private int[] _data;

        [GlobalSetup]
        public void Setup()
        {
            _data = Generators.GenerateRandom(1000, 1, 10000);
        }

        [Benchmark]
        public void InsertionSort()
        {
            var array = (int[])_data.Clone();
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}

            //    public static int[] InsertionSort(int[] arr)
            //    {
            //        int n = arr.Length;

            //        for (int i = 1; i < n; i++) 
            //        {
            //            int key = arr[i];
            //            int j = i - 1;

            //            while (j >= 0 && arr[j] > key)
            //            {
            //                arr[j + 1] = arr[j];
            //                j = j - 1;
            //            }
            //            arr[j + 1] = key;
            //        }

            //        return arr;
            //    }


            //    public static int[] MergeSort(int[] arr)
            //    {
            //        if (arr.Length < 2)
            //        {
            //            return arr;
            //        }

            //        int middle = arr.Length / 2;

            //        int[] firstHalf = MergeSort(arr.Take(middle).ToArray());
            //        int[] secondHalf = MergeSort(arr.Skip(middle).ToArray());

            //        return Merge(firstHalf, secondHalf);
            //    }

            //    public static int[] Merge(int[] firstArr, int[] secondArr)
            //    {
            //        int[] finalArr = new int[firstArr.Length + secondArr.Length];
            //        int i = 0; 
            //        int j = 0;

            //        while (i < firstArr.Length && j < secondArr.Length)
            //        {
            //            if (firstArr[i] <= secondArr[j])
            //            {
            //                finalArr.Append(firstArr[i]);
            //                i++;
            //            }
            //            else
            //            {
            //                finalArr.Append(secondArr[j]);
            //                j++;
            //            }
            //        }

            //        while (i < firstArr.Length)
            //        {
            //            finalArr.Append(firstArr[i]);
            //            i++;
            //        }

            //        while (j < secondArr.Length)
            //        {
            //            finalArr.Append(secondArr[j]);
            //            j++;
            //        }

            //        return finalArr;
            //    }
            //}
        

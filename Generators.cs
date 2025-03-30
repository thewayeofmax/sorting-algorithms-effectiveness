using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_effectiveness
{
    public static class Generators
    {
        public static int[] GenerateRandom(int size, int minVal, int maxVal)
        {
            Random rnd = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(minVal, maxVal);
            }

            return arr;
        }

        public static int[] GenerateSorted(int size, int minVal, int maxVal)
        {
            int[] arr = GenerateRandom(size, minVal, maxVal);
            Array.Sort(arr);

            return arr;
        }

        public static int[] GenerateReversed(int size, int minVal, int maxVal)
        {
            int[] arr = GenerateSorted(size, minVal, maxVal);
            Array.Reverse(arr);

            return arr;
        }

        //function will return an array that has 75% of it's values sorted, the rest is unsorted
        public static int[] GenerateAlmostSorted(int size, int minVal, int maxVal) => GenerateSorted(size / 4 * 3, minVal, maxVal).Concat
                (GenerateRandom(size / 4, minVal, maxVal)).ToArray();

        /*
         * function will return unsorted array with few unique values
         * 
         * table - amount of elements - range of values in function
         * small -  up  to 10 - (0-2)
         * medium - (11 - 1000) - (0-10)
         * big - (1001 - 100000) - (0-30)
         * bigger - from 100001 - (0-(size / (size / 100)))
         */
        public static int[] GenerateFewUniques(int size)
        {
            int rndMaxVal = 0;

            if (size <= 10)
            {
                rndMaxVal = 3;
            }
            else if (size > 10  && size <= 1000)
            {
                rndMaxVal = 10;
            }
            else if (size > 1001 && size <= 100000)
            {
                rndMaxVal = 30;
            }
            else 
            {
                rndMaxVal = size / (size / 100);
            }

            int[] arr = GenerateRandom(size, 0, rndMaxVal);

            return arr;
        }
    }
}

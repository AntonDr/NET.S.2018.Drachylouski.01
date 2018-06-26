using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyleCop;

namespace MethodsOfSort
{
    /// <summary>
    /// Class describing a methods of sorting
    /// </summary>
    public static class MethodsOfSorting
    {
        /// <summary>
        /// Sorts the source array in ascending order
        /// </summary>
        /// <param name="array">Source array</param>
        public static void QuickSort(this int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Sorts the source array in ascending order from the specified indexes
        /// </summary>
        /// <param name="array">Source array</param>
        /// <param name="first">From</param>
        /// <param name="last">To</param>
        private static void QuickSort(int[] array, int first, int last)
        {

            int m = array[(last - first) / 2 + first];

            int i = first, j = last;

            while (i <= j)
            {
                while (array[i] < m && i <= last)
                {
                    ++i;
                }

                while (array[j] > m && j >= first)
                {
                    --j;
                }

                if (i <= j)
                {
                    Swap(ref array[i], ref array[j]);
                    ++i;
                    --j;
                }
            }

            if (j > first) QuickSort(array, first, j);

            if (i < last) QuickSort(array, i, last);

        }

        /// <summary>
        /// Сhanges values in places
        /// </summary>
        /// <param name="a">a->b</param>
        /// <param name="b">b->a</param>
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Sorts the source array in ascending order
        /// </summary>
        /// <param name="array">Source array</param>
        public static void MergeSort(this int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Sorts the source array in ascending order from the specified indexes
        /// </summary>
        /// <param name="array">Source array</param>
        /// <param name="left">From</param>
        /// <param name="right">To</param>
        public static void MergeSort(this int[] array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);
                Merge(array, left, (mid + 1), right);
            }
        }

        /// <summary>
        /// Merges the data into the original array
        /// </summary>
        /// <param name="array">Source array</param>
        /// <param name="left">from</param>
        /// <param name="mid">Middle index</param>
        /// <param name="right">To</param>
        private static void Merge(int[] array, int left, int mid, int right)
        {

            int[] temp = new int[array.Length];

            int i, leftEnd, lengthOfarray, tmpPos;

            leftEnd = mid - 1;
            tmpPos = left;
            lengthOfarray = right - left + 1;

            while ((left <= leftEnd) && (mid <= right))
            {
                if (array[left] <= array[mid])
                {
                    temp[tmpPos++] = array[left++];
                }
                else
                {
                    temp[tmpPos++] = array[mid++];
                }
            }

            while (left <= leftEnd)
            {
                temp[tmpPos++] = array[left++];
            }

            while (mid <= right)
            {
                temp[tmpPos++] = array[mid++];
            }

            for (i = 0; i < lengthOfarray; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
    }
}

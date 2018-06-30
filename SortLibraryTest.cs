using System.Linq;
using System.Security.Cryptography;


namespace SortLibraryTest
{
    using System;

    using NUnit.Framework;

    using MethodsOfSort;

    [TestFixture]
    public class SortLibraryTest
    {
        [TestCase(new int[] { 4, 2, 7, 1 }, ExpectedResult = new int[] { 1, 2, 4, 7 })]
        [TestCase(new int[] { 1, 5, 3, -2, 0 }, ExpectedResult = new int[] { -2, 0, 1, 3, 5 })]
        [TestCase(new int[] { 1, 1, 5, 3, -2, 0 }, ExpectedResult = new int[] { -2, 0, 1, 1, 3, 5 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 0 }, ExpectedResult = new int[] { 0, 1, 1, 1, 1, 1, 1 })]
        public int[] SortTest1(int[] array)
        {
            array.QuickSort();
            return array;
        }

        [TestCase()]
        public void SortTestOnBigSizeArray()
        {
            int[] array = new int[int.MaxValue/10000];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = rand.Next(int.MinValue, int.MaxValue) - int.MaxValue / 4;
            }

            int[] expected = array.OrderBy(i => i).ToArray();
            MethodsOfSorting.MergeSort(array);

            CollectionAssert.AreEqual(array,expected);
        }
    }





}
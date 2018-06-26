namespace SortLibraryTest
{
    using System;

    using NUnit.Framework;

    using MethodsOfSort;

    [TestFixture]
    public class SortLibraryTest
    {
        [TestCase(new int[] { 4, 2, 7, 1 }, ExpectedResult = new int[] { 1, 2, 4, 7 })]
        public int[] SortTest1(int[] array)
        {
            array.QuickSort();
            return array;
        }

        [TestCase(new int[] { 1, 5, 3, -2, 0 }, ExpectedResult = new int[] { -2, 0, 1, 3, 5 })]
        public int[] SortTest2(int[] array)
        {
           array.MergeSort(0,array.Length-1);
            return array;
        }

        [TestCase(new int[] { 1, 1, 5, 3, -2, 0 }, ExpectedResult = new int[] { -2, 0, 1, 1, 3, 5 })]
        public int[] SortTest3(int[] array)
        {
            array.QuickSort();
            return array;
        }

        [TestCase(new int[] { -91, 1, 52, 3, -2, 0,122222 }, ExpectedResult = new int[] { -91, -2, 0, 1, 3, 52,122222 })]
        public int[] SortTest4(int[] array)
        {
            array.QuickSort();
            return array;
        }

        [TestCase(new int[] { 1, 1, 1,1,1,1, 0 }, ExpectedResult = new int[] { 0, 1, 1, 1, 1, 1, 1 })]
        public int[] SortTest5(int[] array)
        {
            array.QuickSort();
            return array;
        }

        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 0 }, ExpectedResult = new int[] { 0, 1, 1, 1, 1, 1, 1 })]
        public int[] SortTest6(int[] array)
        {
            array.MergeSort();
            return array;
        }
    }





}
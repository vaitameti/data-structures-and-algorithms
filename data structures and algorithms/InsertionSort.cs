using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{
    public static class InsertionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && array[j].CompareTo(array[j-1]) < 0) //it will iterate throgh all elements to left from jth position(sorted part)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}

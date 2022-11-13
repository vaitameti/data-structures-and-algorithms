using System;
using System.Collections.Generic;
using System.Text;

namespace data_structures_and_algorithms
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length -1; i++)
            {
                int minIndex = i; //setting index(unsorted part)
                T minValue = array[i];//setting the minimum value in unsorted part
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[j].CompareTo(minValue) < 0)  
                    {
                        minIndex = j; 
                        minValue = array[j];
                    }
                }
                Swap(array, i, minIndex);
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

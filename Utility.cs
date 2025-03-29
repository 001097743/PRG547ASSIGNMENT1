using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547ASSIGNMENT1
{
    internal class Utility
    {
        public enum SortOrder { ASC, DESC }
        public static int LinearSeachArray<T>(T[] array, T target) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (target.CompareTo(array[i]) == 0) { return i; } else { i++; }
            }
            return -1;
        }

        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;

            do
            {
                mid = (min + max) / 2;
                if (target.CompareTo(array[mid]) == 0)
                {
                    return mid;
                }

                if (target.CompareTo(array[mid]) > 0)
                {
                    min = mid++;
                }
                else
                {
                    max = mid--;
                }
            } while (min <= max);
            return -1;
        }



        public static void SortAsc<T>(T[] array) where T : IComparable<T>
        {
            Sort<T>(array, SortOrder.ASC);
        }
        public static void SortDesc<T>(T[] array) where T : IComparable<T>
        {
            Sort<T>(array, SortOrder.DESC);

        }

        public static void Sort<T>(T[] array, SortOrder order) where T : IComparable<T>
        {
            int n = array.Length;
            T temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            if (order == SortOrder.DESC)
            {
                Array.Reverse(array);
            }
        }
    }
}

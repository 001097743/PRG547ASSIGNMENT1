using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547ASSIGNMENT1
{
    class Utility
    {
        public enum SortOrder { ASC, DESC }

        /// <summary>
        /// Linear search an array of any type
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="array">Array to search in</param>
        /// <param name="target">Search target</param>
        /// <returns>Index of target in arry if found, -1 if not found</returns>
        public static int LinearSeachArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;
            while (!found && i < array.Length)
            {
                if (target.CompareTo(array[i]) == 0)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            return i < array.Length ? i : -1;

        }

        /// <summary>
        /// Binary search an array of any type
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="array">Array to search in</param>
        /// <param name="target">Search target</param>
        /// <returns>Index of target in arry if found, -1 if not found</returns>
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
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            } while (min <= max);

            return -1;
        }


        /// <summary>
        /// Sort an array of any type in ascending order
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="array">Array to sort</param>
        public static void SortAsc<T>(T[] array) where T : IComparable<T>
        {
            Sort<T>(array, SortOrder.ASC);
        }

        /// <summary>
        /// Sort an array of any type in descending order
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="array">Array to sort</param>
        public static void SortDesc<T>(T[] array) where T : IComparable<T>
        {
            Sort<T>(array, SortOrder.DESC);

        }

        /// <summary>
        /// Sort an array of any type
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="array">Array to sort</param>
        /// <param name="order">Enum sort order</param>
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

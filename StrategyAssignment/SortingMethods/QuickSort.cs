using System.Collections.Generic;
using System;

namespace StrategyAssignment
{
    public class QuickSort : ISortingMethod
    {
        public List<TShirt> Sort(TShirt[] tShirts)
        {
            //TODO
            return null;
        }

        static int partition(TShirt[] arr, int low, int high, Func<TShirt, TShirt, bool> IsSwappable)
        {
            TShirt pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if(IsSwappable(pivot, arr[j]))
                {
                    i++;
                    TShirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            TShirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void SortFacade(TShirt[] arr, Func<TShirt, TShirt, bool> IsSwappable)
        {
            QuickSort.SortAll(arr, 0, arr.Length - 1, IsSwappable);
        }

        public static void SortAll(TShirt[] arr, int low, int high, Func<TShirt, TShirt, bool> IsSwappable)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high, IsSwappable);
                SortAll(arr, low, pi - 1, IsSwappable);
                SortAll(arr, pi + 1, high, IsSwappable);
            }

        }
    }
}

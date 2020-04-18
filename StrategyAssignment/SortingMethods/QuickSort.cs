using System.Collections.Generic;
using System;

namespace StrategyAssignment
{
    public class QuickSort : SortingMethod
    {
        public override void Sort(TShirt[] tShirts, Func<TShirt, TShirt, bool> IsSwappable)
        {
            QuickSort.SortingProcedure(tShirts, 0, tShirts.Length - 1, IsSwappable);
        }

        private static int Partition(TShirt[] tShirts, int low, int high, Func<TShirt, TShirt, bool> IsSwappable)
        {
            TShirt pivot = tShirts[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if(IsSwappable(pivot, tShirts[j]))
                {
                    i++;
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
            }
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;
            return i + 1;
        }

        private static void SortingProcedure(TShirt[] tShirts, int low, int high, Func<TShirt, TShirt, bool> IsSwappable)
        {
            if (low < high)
            {
                int pi = Partition(tShirts, low, high, IsSwappable);
                SortingProcedure(tShirts, low, pi - 1, IsSwappable);
                SortingProcedure(tShirts, pi + 1, high, IsSwappable);
            }

        }
    }
}

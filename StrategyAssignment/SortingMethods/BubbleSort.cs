using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
    public class BubbleSort : SortingMethod
    {
        public override void Sort(TShirt[] tShirts,Func<TShirt,TShirt,bool> isSwappable)
        {
            TShirt temp;
            for (int j = 0; j <= tShirts.Length - 2; j++)
            {
                for (int i = 0; i <= tShirts.Length - 2; i++)
                {
                    if(isSwappable(tShirts[i],tShirts[i+1]))
                    {
                        temp = tShirts[i + 1];
                        tShirts[i + 1] = tShirts[i];
                        tShirts[i] = temp;
                    }
                }
            }
        }
    }
}

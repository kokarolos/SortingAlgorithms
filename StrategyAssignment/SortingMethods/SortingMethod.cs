using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
    public abstract class SortingMethod
    {
         public abstract void Sort(TShirt[] tShirts, Func<TShirt, TShirt, bool> IsSwappable);
    }
}

using System.Collections.Generic;

namespace StrategyAssignment
{
    public interface ISortingMethod
    {
        List<TShirt> Sort(TShirt[] tShirts);
    }
}

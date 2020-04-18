using System.Collections.Generic;

namespace StrategyAssignment
{
    public class SizeVariation : Variation
    {
        private static Dictionary<Size, decimal> _sizeCosts;

        static SizeVariation()
        {
            _sizeCosts = new Dictionary<Size, decimal>()
            {
                { Size.XS, -1m },
                { Size.S, -0.5m },
                { Size.M, 0m },
                { Size.L, 0.5m },
                { Size.XL, 1m },
                { Size.XXL, 2m },
                { Size.XXXL, 3.5m }
            };
        }

        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _sizeCosts[tshirt.Size];
            return tshirt.Price;
        }
    }
}

using System.Collections.Generic;

namespace StrategyAssignment
{
    public class ColorVariation : Variation
    {
        private static Dictionary<Color, decimal> _colorVariations;
        static ColorVariation()
        {
            _colorVariations = new Dictionary<Color, decimal>()
            {
                { Color.BLUE , 5m},
                { Color.GREEN , 6m},
                { Color.ORANGE , 2m},
                { Color.INDIGO , 2.3m},
                { Color.VIOLET , 0.3m},
                { Color.YELLOW , -2.3m},
                { Color.RED , 7.3m}
            };
        }
        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _colorVariations[tshirt.Color];
            return tshirt.Price;
        }
    }
}

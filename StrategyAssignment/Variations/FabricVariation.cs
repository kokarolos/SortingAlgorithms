using System.Collections.Generic;

namespace StrategyAssignment
{
    public class FabricVariation : Variation
    {
        private static Dictionary<Fabric, decimal> _fabricVariations;
        static FabricVariation()
        {
            _fabricVariations = new Dictionary<Fabric, decimal>()
            {
                { Fabric.CASHMERE, 15m },
                { Fabric.COTTON, 5m },
                { Fabric.LINEN, 9m },
                { Fabric.POLYESTER, 6m },
                { Fabric.RAYON, 8m },
                { Fabric.SILK, 22m },
                { Fabric.WOOL, 12m }
            };
        }
        public override decimal Cost(TShirt tshirt)
        {
            tshirt.Price += _fabricVariations[tshirt.Fabric];
            return tshirt.Price;
        }
    }
}

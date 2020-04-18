using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
    public class DataLoader
    {
        public static List<TShirt> GenerateTShirts()
        {
            List<TShirt> tShirts = new List<TShirt>();
            for (int i = 0; i <= 40; i++)
            {
                Array valuesOfColor = Enum.GetValues(typeof(Color));
                var randomColor = (Color)valuesOfColor.GetValue(MyRandom.GenerateRandom(valuesOfColor.Length));
                Array valuesOfSize = Enum.GetValues(typeof(Size));
                var randomSize = (Size)valuesOfSize.GetValue(MyRandom.GenerateRandom(valuesOfSize.Length));
                Array valuesOfFabric = Enum.GetValues(typeof(Fabric));
                var randomFabric = (Fabric)valuesOfFabric.GetValue(MyRandom.GenerateRandom(valuesOfFabric.Length));
                tShirts.Add(new TShirt(randomColor, randomSize, randomFabric));
            }
            return tShirts;
        }
    }
}

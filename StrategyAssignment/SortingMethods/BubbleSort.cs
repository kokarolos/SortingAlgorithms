using System.Collections.Generic;

namespace StrategyAssignment
{
    public class BubbleSort : ISortingMethod
    {
        public List<TShirt> Sort(TShirt[] tShirts)
        {

            return null;
        }
        public static void SizeAsc(List<TShirt> tShirts)
        {
            TShirt temp;
            for (int j = 0; j <= tShirts.Count - 2; j++)
            {
                for (int i = 0; i <= tShirts.Count - 2; i++)
                {
                    if (tShirts[i].Size > tShirts[i + 1].Size)
                    {
                        temp = tShirts[i + 1];
                        tShirts[i + 1] = tShirts[i];
                        tShirts[i] = temp;
                    }
                }
            }
        }

        public static void SizeDesc(List<TShirt> tShirts)
        {
            TShirt temp;
            for (int j = 0; j <= tShirts.Count - 2; j++)
            {
                for (int i = 0; i <= tShirts.Count - 2; i++)
                {
                    if (tShirts[i].Size < tShirts[i + 1].Size)
                    {
                        temp = tShirts[i + 1];
                        tShirts[i + 1] = tShirts[i];
                        tShirts[i] = temp;
                    }
                }
            }
        }
        public static void ColorAsc(List<TShirt> tShirts)
        {
            TShirt temp;
            for (int j = 0; j <= tShirts.Count - 2; j++)
            {
                for (int i = 0; i <= tShirts.Count - 2; i++)
                {
                    if (tShirts[i].Color > tShirts[i + 1].Color)
                    {
                        temp = tShirts[i + 1];
                        tShirts[i + 1] = tShirts[i];
                        tShirts[i] = temp;
                    }
                }
            }
        }

        public static void ColorDesc(List<TShirt> tShirts)
        {
            TShirt temp;
            for (int j = 0; j <= tShirts.Count - 2; j++)
            {
                for (int i = 0; i <= tShirts.Count - 2; i++)
                {
                    if (tShirts[i].Color < tShirts[i + 1].Color)
                    {
                        temp = tShirts[i + 1];
                        tShirts[i + 1] = tShirts[i];
                        tShirts[i] = temp;
                    }
                }
            }
        }
        public static void FabricAsc(List<TShirt> tShirts)
        {
            TShirt temp;
            for (int j = 0; j <= tShirts.Count - 2; j++)
            {
                for (int i = 0; i <= tShirts.Count - 2; i++)
                {
                    if (tShirts[i].Fabric > tShirts[i + 1].Fabric)
                    {
                        temp = tShirts[i + 1];
                        tShirts[i + 1] = tShirts[i];
                        tShirts[i] = temp;
                    }
                }
            }
        }

        public static void FabricDesc(List<TShirt> tShirts)
        {
            TShirt temp;
            for (int j = 0; j <= tShirts.Count - 2; j++)
            {
                for (int i = 0; i <= tShirts.Count - 2; i++)
                {
                    if (tShirts[i].Fabric < tShirts[i + 1].Fabric)
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

using System;

namespace StrategyAssignment
{
    public static class MyRandom
    {
        static Random random = new Random();
        public static int GenerateRandom(int maximum)
        {
            return random.Next(maximum);
        }

    }
}

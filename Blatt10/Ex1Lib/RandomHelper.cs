using System;

namespace Ex1
{
    public static class RandomHelper
    {
        private static Random rand;

        static RandomHelper()
        {
            rand = new Random();
        }

        public static decimal GetStockFactor()
        {
            return (decimal)(rand.NextDouble()*1.8+0.2);
        }

        public static bool GetBool()
        {
            return rand.Next(2) == 0;
        }
        
        //trueSkewFactor determines how often you get true, and must be between 0.0 and 1.0
        public static bool GetBool(float trueSkewFactor)
        {
            return rand.NextDouble() <= trueSkewFactor;
        }
    }
}
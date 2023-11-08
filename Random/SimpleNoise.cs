
namespace IBX_Utilities.Random
{
    public static class SimpleNoise
    {
        public static float Generate1DNoise(float x, int seed)
        {
            System.Random rand = new System.Random(seed);
            return (float)rand.NextDouble();
        }

        public static float Generate2DNoise(float x, float y, int seed)
        {
            System.Random rand = new System.Random(seed);
            return (float)rand.NextDouble();
        }

        public static float Generate3DNoise(float x, float y, float z, int seed)
        {
            System.Random rand = new System.Random(seed);
            return (float)rand.NextDouble();
        }
    }
}

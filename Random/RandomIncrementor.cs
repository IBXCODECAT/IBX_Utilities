using System.Security;
using System

namespace IBX_Utilities.Random
{
    public static class RandomIncrementor
    {

        public static int RandomIncrementDecrement(int currentValue, int modFloor = -2, int modCeiling = 2, int min = 0, int max = 1)
        {
            // Create a new instance of the Random class for generating random numbers.
            System.Random random = new System.Random();

            // Generate a random modifier value within the specified range [modFloor, modCeiling).
            int modifier = random.Next(modFloor, modCeiling);

            // Add the random modifier to the current value, effectively incrementing or decrementing it.
            currentValue += modifier;

            // Clamp the current value to the min and max provided
            if(currentValue < min) currentValue = min;
            if(currentValue > max) currentValue = max;

            // Return the updated current value.
            return currentValue;
        }

    }
}

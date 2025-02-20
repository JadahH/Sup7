namespace Int;

public class GetArray
{

 /// <summary>
        /// Returns the average, minimum, and maximum values of the array.
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <returns>A tuple containing the average, min, and max values</returns>
        public static (double Average, int Min, int Max) GetStatistics(int[] numbers)
        {
            return (numbers.Average(), numbers.Min(), numbers.Max());
        }
}


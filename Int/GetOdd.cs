namespace Int;

public class GetOdd
{
/// <summary>
        /// Returns all odd numbers from the shuffled array with an option to skip numbers.
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <param name="skip">Optional number of items to skip</param>
        /// <returns>Enumerable collection of odd numbers</returns>
        public static IEnumerable<int> GetShuffledOddNumbers(int[] numbers, int skip = 0)
        {
            Random rnd = new Random();
            return numbers.OrderBy(n => rnd.Next()).Where(n => n % 2 == 1).Skip(skip);
        }
    }


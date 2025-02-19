namespace Int;

public class GetEven
{

        /// <summary>
        /// Returns all even numbers from an array with an option to skip numbers.
        /// </summary>
        /// <param name="numbers">The array of integers</param>
        /// <param name="skip">Optional number of items to skip</param>
        /// <returns>Enumerable collection of even numbers</returns>
        public static IEnumerable<int> GetEvenNumbers(int[] numbers, int skip = 0)
        {
            return numbers.Where(n => n % 2 == 0).Skip(skip);
 
        }
}

using System.Linq;
using Xunit;
namespace Int.Tests;


public class GetOddTests
{
    {
        [Fact]
        public void GetOdd_ReturnOddNumbers()
        {
            int[] numbers = Enumerable.Range(0, 1000000).ToArray();
            var result = GetOdd.GetShuffledOddNumbers(numbers);
            Assert.All(result, num => Assert.True(num % 2 == 1));
        }
    }

}


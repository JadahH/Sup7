using System.Linq;
using Xunit;

namespace Int.Tests;

public class GetEvenTest
{
    [Fact]
    public void GetEven_ReturnNumbers()
    {
        int[] numbers = Enumerable.Range(0, 1000000).ToArray();
            var result = GetEven.GetEvenNumbers(numbers);
            Assert.All(result, num => Assert.True(num % 2 == 0));
        }

        [Fact]
        public void GetEven_SkipNumbers()
        {
            int[] numbers = Enumerable.Range(0, 100).ToArray();
            int skip = 10;
            var result = GetEven.GetEvenNumbers(numbers, skip);
            Assert.Equal(40, result.Count());
        }
    }

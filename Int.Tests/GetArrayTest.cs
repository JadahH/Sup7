using System.Linq;
using Xunit;

namespace Int.Tests;

public class GetArrayTests
    {
        [Fact]
        public void GetArray_ShouldReturnCorrectStatistics()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            var stats = GetArray.GetStatistics(numbers);
            Assert.Equal(50.5, stats.Average);
            Assert.Equal(1, stats.Min);
            Assert.Equal(100, stats.Max);
        }
    }

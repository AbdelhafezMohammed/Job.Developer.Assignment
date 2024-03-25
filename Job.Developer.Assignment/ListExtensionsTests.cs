using Xunit;

namespace Job.Developer.Assignment
{
    public class ListExtensionsTests
    {
        [Fact]
        public void FindCombinations1Test()
        {
            var numbers = new[] { 0, 1 };
            var combination = new[] { 0, 1 };
            var expectedNumberOfCombinations = new[] { new[] { 0, 1 } };

            var result = numbers.FindCombinations(combination);

            Assert.Equal(expectedNumberOfCombinations, result);
        }

        [Fact]
        public void FindCombinations2Test()
        {
            var numbers = new[] { 1, 2, 1, 1, 2, 3 };
            var combination = new[] { 1, 2 };
            var expectedNumberOfCombinations = new[] { new[] { 0, 1 }, new[] { 0, 4 }, new[] { 2, 4 }, new[] { 3, 4 } };

            var result = numbers.FindCombinations(combination);

            Assert.Equal(expectedNumberOfCombinations, result);
        }

        [Fact]
        public void FindCombinations3Test()
        {
            var numbers = new[] { 1, 4, 3, 3, 5, 6, 1, 4, 3, 6, 3 };
            var combination = new[] { 1, 4, 3, 4 };
            var expectedNumberOfCombinations = new[] { new[] { 0, 1, 2, 7 }, new[] { 0, 1, 3, 7 } };

            var result = numbers.FindCombinations(combination);

            Assert.Equal(expectedNumberOfCombinations, result);
        }

        [Fact]
        public void FindCombinations4Test()
        {
            var numbers = new[] { 1, 4, 3, 3, 5, 6, 1, 4, 3, 6, 3 };
            var combination = new[] { 1, 4, 3 };

            var actual = numbers.FindCombinations(combination);
            var expected = new[] { new[] { 0, 1, 2 }, new[] { 0, 1, 3 }, new[] { 0, 1, 8 }, new[] { 0, 1, 10 }, new[] { 0, 7, 8 }, new[] { 0, 7, 10 }, new[] { 6, 7, 8 }, new[] { 6, 7, 10 } };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindCombinations5Test()
        {
            var numbers = new[] { 1, 0, 1, 0, 1 };
            var combination = new[] { 1, 1 };

            var actual = numbers.FindCombinations(combination);
            var expected = new[] { new[] { 0, 2 }, new[] { 0, 4 }, new[] { 2, 4 } };

            Assert.Equal(expected, actual);
        }
    }
}

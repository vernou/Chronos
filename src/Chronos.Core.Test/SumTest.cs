using Xunit;

namespace Chronos.Core.Test
{
    public class SumTest
    {
        [Fact]
        public void FiveMoreTwoEqualSeven()
        {
            Assert.Equal(7, new Sum(5, 2).Value);
        }

        [Fact]
        public void FailTest()
        {
            Assert.Equal(9, new Sum(5, 2).Value);
        }
    }
}
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
    }
}

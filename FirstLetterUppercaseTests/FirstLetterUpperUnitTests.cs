using Katas;
using Xunit;

namespace FirstLetterUppercaseTests
{
    public class FirstLetterUpperUnitTests
    {
        [Fact]
        public void HelloWordShouldBeTrue()
        {
            Assert.True(FirstLetterUppercase.IsFirstLetterUppercase("Hello World"));
        }

        [Fact]
        public void LowercaseHelloShouldBeFalse()
        {
            Assert.False(FirstLetterUppercase.IsFirstLetterUppercase("hello"));
        }
    }
}

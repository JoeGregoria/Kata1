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

        [Fact]
        public void NullShouldBeFalse()
        {
            Assert.False(FirstLetterUppercase.IsFirstLetterUppercase(null));
        }

        [Fact]
        public void EmptyShouldBeFalse()
        {
            Assert.False(FirstLetterUppercase.IsFirstLetterUppercase(""));
        }

        [Fact]
        public void SpaceShouldBeFalse()
        {
            Assert.False(FirstLetterUppercase.IsFirstLetterUppercase(" "));
        }

        [Fact]
        public void TabShouldBeFalse()
        {
            Assert.False(FirstLetterUppercase.IsFirstLetterUppercase("\t"));
        }

        [Fact]
        public void SingleCapitalShouldBeTrue()
        {
            Assert.True(FirstLetterUppercase.IsFirstLetterUppercase("A"));
        }

        [Fact]
        public void SingleLowerShouldBeFalse()
        {
            Assert.False(FirstLetterUppercase.IsFirstLetterUppercase("a"));
        }

        [Fact]
        public void AccentUpperAShouldBeTrue()
        {
            Assert.True(FirstLetterUppercase.IsFirstLetterUppercase("À"));
        }


        [Fact]
        public void AccentLowerAShouldBeFalse()
        {
            Assert.False(FirstLetterUppercase.IsFirstLetterUppercase("à"));
        }
    }
}

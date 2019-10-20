using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void return_the_representing_string_when_convert_a_regular_number(int number, String expected)
        {
            Assert.Equal(expected, FizzBuzz.Convert(number));
        }
    }
}

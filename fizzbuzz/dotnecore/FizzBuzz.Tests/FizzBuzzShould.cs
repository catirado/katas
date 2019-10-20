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

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void return_Fizz_when_convert_a_number_multiple_of_3(int number)
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(number));
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void return_Buzz_when_convert_a_number_multiple_of_5(int number)
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(number));
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void return_FizzBuzz_when_convert_a_number_multiple_of_3_and_multiple_of_5(int number)
        {
            Assert.Equal("FizzBuzz", FizzBuzz.Convert(number));
        }
    }
}

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

        [Fact]
        public void return_Buzz_when_i_fizzbuzz_the_number_5()
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(5));
        }

        [Fact]
        public void return_Buzz_when_i_fizzbuzz_the_number_10()
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(10));
        }

        [Fact]
        public void return_Buzz_when_i_fizzbuzz_the_number_20()
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(20));
        }
    }
}

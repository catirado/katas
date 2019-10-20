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

        [Fact]
        public void return_Fizz_when_i_fizzbuzz_the_number_3()
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(3));
        }

        [Fact]
        public void return_Fizz_when_i_fizzbuzz_the_number_6()
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(6));
        }

        [Fact]
        public void return_Fizz_when_i_fizzbuzz_the_number_9()
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(9));
        }
    }
}

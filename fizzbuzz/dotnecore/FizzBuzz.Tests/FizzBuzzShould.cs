using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzShould
    {
        [Fact]
        public void return_string_1_when_i_fizzbuzz_the_number_1()
        {
            Assert.Equal("1", FizzBuzz.Convert(1));
        }
    }
}

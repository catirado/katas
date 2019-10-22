using FluentAssertions;
using Xunit;

namespace LeapYear.Tests
{
    public class YearShould
    {

        [Fact]
        public void be_a_leap_if_is_divisible_by_400()
        {
            var year = new Year(2000);
            year.IsLeap().Should().BeTrue();  
        }

        [Fact]
        public void not_be_a_leap_if_is_divisible_by_100_and_not_by_400()
        {
            var year = new Year(1800);
            year.IsLeap().Should().BeFalse();
        }

        [Fact]
        public void be_a_leap_if_is_divisible_by_4()
        {
            var year = new Year(2016);
            year.IsLeap().Should().BeTrue();
        }

        [Fact]
        public void not_be_a_leap_if_is_not_divisible_by_4()
        {
            var year = new Year(2017);
            year.IsLeap().Should().BeFalse();
        }


    }
}

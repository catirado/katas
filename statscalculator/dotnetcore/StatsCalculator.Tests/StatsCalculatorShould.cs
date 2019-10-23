using System;
using Xunit;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;

namespace StatsCalculator.Tests
{
    public class StatsCalculatorShould
    {
        [Fact]
        public void calculate_the_minimum_value_of_a_sequence_of_integers()
        {
            var sequence = Enumerable.Range(-2, 10);
            var calculator = new StatsCalculator(sequence);
            calculator.Min().Should().Be(-2);
        }

        [Fact]
        public void calculate_the_minimum_value_of_a_sequence_of_only_one_integer()
        {
            var sequence = new List<int> { -2 };
            var calculator = new StatsCalculator(sequence);
            calculator.Min().Should().Be(-2);
        }

        [Fact]
        public void calculate_the_maximum_value_of_a_sequence_of_integers()
        {
            var sequence = Enumerable.Range(1, 10);
            var calculator = new StatsCalculator(sequence);
            calculator.Max().Should().Be(10);
        }

        [Fact]
        public void calculate_the_maximum_value_of_a_sequence_of_only_one_integer()
        {
            var sequence = new List<int> { -2 };
            var calculator = new StatsCalculator(sequence);
            calculator.Max().Should().Be(-2);
        }

        [Fact]
        public void calculate_the_number_of_elements_of_a_sequence_of_integers()
        {
            var sequence = Enumerable.Range(1, 10);
            var calculator = new StatsCalculator(sequence);
            calculator.Count().Should().Be(10);
        }

        [Fact]
        public void calculate_the_average_a_sequence_of_integers()
        {
            var sequence = new List<int> { 5, 10, 20, 5 };
            var calculator = new StatsCalculator(sequence);
            calculator.Avg().Should().Be(10);
        }

    }
}

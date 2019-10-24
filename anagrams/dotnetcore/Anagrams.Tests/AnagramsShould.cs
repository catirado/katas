using System;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace Anagrams.Tests
{
    public class AnagramsShould
    {
        [Fact]
        public void return_empty_list_if_the_input_is_empty()
        {
            Anagrams.Of("").Should().BeEmpty();
        }

        [Fact]
        public void return_the_list_with_himself_if_the_input_has_one_character()
        {
            Anagrams.Of("a").Should().BeEquivalentTo(new List<String> { "a" });
        }

        [Fact]
        public void return_the_list_of_anagrams_if_the_input_has_two_character()
        {
            var expectedAnagrams = new List<String> { "bi", "ib" };
            Anagrams.Of("bi").Should().BeEquivalentTo(expectedAnagrams);
        }

        [Fact]
        public void return_the_list_of_anagrams_if_the_input_has_three_characters()
        {
            var expectedAnagrams = new List<String> { "bir", "bri", "ibr", "irb", "rbi", "rib" };
            Anagrams.Of("bir").Should().BeEquivalentTo(expectedAnagrams);
        }

        [Fact]
        public void return_the_list_of_anagrams_if_the_input_has_four_characters()
        {
            var expectedAnagrams = new List<String> { "biro", "bior", "brio", "broi", "boir", "bori",
                                                      "ibro", "ibor", "irbo", "irob", "iobr", "iorb",
                                                      "rbio", "rboi", "ribo", "riob", "roib", "robi",
                                                      "obir", "obri", "oibr", "oirb", "orbi", "orib"};
            Anagrams.Of("biro").Should().BeEquivalentTo(expectedAnagrams);
        }
    }
}

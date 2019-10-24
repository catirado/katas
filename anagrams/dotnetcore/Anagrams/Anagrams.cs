using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    public class Anagrams
    {
        public static IList<String> Of(string input)
        {
            var anagrams = new List<String>();

            if (input.Length == 1)
                return new List<String> { input };

            for (int i = 0; i < input.Length; i++)
            {
                String character = input[i].ToString();
                var anagramsOfRestLetters = Anagrams.Of(RemoveCharFromPosition(input, i));
                var anagramasWithCharacterFirst = anagramsOfRestLetters.Select(restLettersAnagrams => character + restLettersAnagrams);
                anagrams.AddRange(anagramasWithCharacterFirst);
            }

            return anagrams;
        }

        private static string RemoveCharFromPosition(string input, int index)
        {
            return input.Remove(index, 1);
        }
    }
}

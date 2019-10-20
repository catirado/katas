using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        private const string FIZZBUZZ = "FizzBuzz";

        public static String Convert(int number)
        {
            if (isDivisibleByThreeAndFive(number))
                return FIZZBUZZ;

            if (isDivisibleByThree(number))
                return FIZZ;

            if (isDivisibleByFive(number))
                return BUZZ;

            return number.ToString();
        }

        private static bool isDivisibleByThreeAndFive(int number)
        {
            return isDivisibleByThree(number) && isDivisibleByFive(number);
        }

        private static bool isDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        private static bool isDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }

    }
}

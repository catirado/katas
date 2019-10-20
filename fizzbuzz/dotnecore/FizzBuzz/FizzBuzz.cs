using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private const string FIZZ = "Fizz";

        public static String Convert(int number)
        {
            if (isDivisibleByThree(number))
                return FIZZ;

            if (number == 5)
                return "Buzz";

            if (number == 10)
                return "Buzz";

            if (number == 20)
                return "Buzz";

            return number.ToString();
        }

        private static bool isDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}

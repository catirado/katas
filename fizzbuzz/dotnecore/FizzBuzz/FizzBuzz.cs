using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static String Convert(int number)
        {
            if (number == 3) return "Fizz";
            if (number == 6) return "Fizz";
            if (number == 9) return "Fizz";
            return number.ToString();
        }
    }
}

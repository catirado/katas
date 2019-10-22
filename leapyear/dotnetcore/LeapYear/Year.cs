using System;
namespace LeapYear
{
    public class Year
    {
        private int year;

        public Year(int year)
        {
            this.year = year;
        }

        public bool IsLeap()
        {
            if (isDivisibleBy(400))
                return true;

            if (isDivisibleBy(100))
                return false;

            return isDivisibleBy(4);

            bool isDivisibleBy(int factor) => year % factor == 0;
        }            
        
    }
}

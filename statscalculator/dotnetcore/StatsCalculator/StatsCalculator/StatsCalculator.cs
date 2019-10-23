using System;
using System.Linq;
using System.Collections.Generic;

namespace StatsCalculator
{
    public class StatsCalculator
    {
        private readonly IEnumerable<int> _sequence;

        private int _min;
        private int _max;
        private int _sum;
        private int _count ;

        public StatsCalculator(IEnumerable<int> sequence)
        {
            InitializeStats(sequence.First());
            CalculateStats(sequence);
        }

        private void InitializeStats(int defaultValue)
        {
            _min = defaultValue;
            _max = defaultValue;
            _sum = 0;
            _count = 0;
        }

        private void CalculateStats(IEnumerable<int> sequence)
        {
            foreach (var number in sequence)
            {
                if (number < _min)
                    _min = number;

                if (number > _max)
                    _max = number;

                _sum += number;

                _count++;
            }
        }

        public int Min() => _min;

        public int Max() => _max;

        public int Count() => _count;

        public double Avg() => _sum / _count;
    }
}

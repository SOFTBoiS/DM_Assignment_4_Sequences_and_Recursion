using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DMAssignment4SequencesAndRecursion
{
    class Rationals : IEnumerable<string>
    {

        public IEnumerator<string> GetEnumerator()
        {
            return new RationalEnumerator();
        }

        public static string Rational(long n)
        {
            // The diagonal line number lₙ from n
            long ln = (long)((-1 + Math.Sqrt(1 + 8 * n)) / 2);
            // Line including n starts at sₙ:
            var sn = ln * (ln + 1) / 2;
            var numerator = CalculateNumerator(n, sn);
            var denominator = CalculateDenominator(n, sn, ln);

            return numerator + "/" + denominator;
        }

        public static long CalculateNumerator(long n, long sn)
        {   
            return n - sn + 1;
        }
        public static long CalculateDenominator(long n, long sn, long ln)
        {
            return ln - (n - sn) + 1;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            for (long i = 0; i < long.MaxValue; i++)
            {
                yield return Rational(i);
            }
        }

        class RationalEnumerator : IEnumerator<string>
        {
            public string Current => Rational(_currIndex);
            private long _currIndex { get; set; }
            object IEnumerator.Current => Current;

            public void Dispose()

            {
            }

            public bool MoveNext()
            {
                return ++_currIndex < long.MaxValue;
            }

            public void Reset()
            {
                _currIndex = -1;
            }
        }
    }
}

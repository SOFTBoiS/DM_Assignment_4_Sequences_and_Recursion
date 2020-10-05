using System;
using static DMAssignment4SequencesAndRecursion.Rationals;

namespace DMAssignment4SequencesAndRecursion
{
    class Program
    {
        static void Main(string[] args)
        {

            long num = 25;

            var rationalNum = Rationals.Rational(num);

            Console.WriteLine($"The {num}th rational number in the sequence is: " + rationalNum);

            Rationals rationals = new Rationals();
            var iterations = 10;
            var current = 0;
            Console.WriteLine("Loop through the iterable from 0-10 with an Enumerable");
            foreach (var x in rationals)
            {
                Console.WriteLine($"The {current++}th number is {x}");
                if (current >= iterations) break;
            }


            current = 0;
            var enumerator = rationals.GetEnumerator();
            Console.WriteLine("Loop through the iterable from 0-10 with an Enumerator");
            while (enumerator.MoveNext() && current < iterations)
            {
                Console.WriteLine($"The {current++}st number is {enumerator.Current}");
            }
        }




        //for (int i = 0; i < 11; i++)
        //{

        //}


        //var test = rational.GetEnumerator();
    }
}


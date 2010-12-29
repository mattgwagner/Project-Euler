using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics;
using System.Threading;

namespace ProjectEuler
{
    class Program
    {
        static EulerProblem problem;

        public static void Main()
        {
            Console.Write("Which problem to run? ");

            int problem_no = int.Parse(Console.ReadLine());

            problem = (EulerProblem)Activator.CreateInstance(Type.GetType("Euler" + problem_no));

            Stopwatch sw = Stopwatch.StartNew();

            using (Timer t = new Timer(o => Console.WriteLine("Elapsed: {0}ms", sw.ElapsedMilliseconds), null, 0, 3000))
            {
                Console.WriteLine("\nAnswer for Question {0}: {1}", problem_no, problem.Solution());

                Console.WriteLine("\nTotal time: {0}ms", sw.ElapsedMilliseconds);
            }

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Base class for implementing solutions to problems, allows easy use of reflection
    /// </summary>
    public abstract class EulerProblem
    {
        public abstract object Solution();

        // borrowed from http://digitalbush.com/2010/02/26/sieve-of-eratosthenes-in-csharp/
        protected static IEnumerable<int> FindPrimesUpToMax(int max)
        {
            var vals = new List<int>((int)(max / (Math.Log(max) - 1.08366)));
            var maxSquareRoot = Math.Sqrt(max);
            var eliminated = new System.Collections.BitArray(max + 1);

            vals.Add(2);

            for (int i = 3; i <= max; i += 2)
            {
                if (!eliminated[i])
                {
                    if (i < maxSquareRoot)
                    {
                        for (int j = i * i; j <= max; j += 2 * i)
                            eliminated[j] = true;
                    }

                    vals.Add(i);
                }
            }

            return vals;
        }
    }

    /// <summary>
    /// Random extension methods to add on to BigInteger for factorials, prime check, or getting factors
    /// </summary>
    public static class ExtensionUtils
    {
        public static Boolean IsPrime(this int integer)
        {
            if (integer % 2 == 0) return true;

            for (int i = 3; i < integer; i++)
            {
                if (integer % i == 0) return false;
            }

            return true;
        }

        public static int Factorial(this int f)
        {
            if (f == 0) return 1;

            return f != 1 ? (f * Factorial(f - 1)) : 1;
        }

        public static BigInteger Factorial(this BigInteger f)
        {
            if (f == 0) return 1;

            return f != 1 ? (f * Factorial(f - 1)) : 1;
        }

        public static Boolean isPalindrome(this String str)
        {
            return str.Equals(new String(str.Reverse().ToArray()));
        }

        public static int Product(this IEnumerable<int> l)
        {
            int product = 1;

            foreach (var i in l)
            {
                product *= i;
            }

            return product;
        }

        /// <summary>
        /// Sums an IEnumerable filled with BigIntegers since this isn't available via normal LINQ
        /// </summary>
        public static BigInteger Sum(this IEnumerable<BigInteger> list)
        {
            BigInteger sum = 0;

            foreach (BigInteger b in list)
            {
                sum += b;
            }

            return sum;
        }
    }
}

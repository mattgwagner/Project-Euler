using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

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

            Console.WriteLine("Answer for Question {0}: {1}", problem.GetType(), problem.Solution());

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Base class for implementing solutions to problems, allows easy use of reflection
    /// </summary>
    public abstract class EulerProblem
    {
        public abstract object Solution();
    }

    /// <summary>
    /// Random extension methods to add on to BigInteger for factorials, prime check, or getting factors
    /// </summary>
    public static class ExtensionUtils
    {
        public static BigInteger factorial(this BigInteger f)
        {
            return f != 1 ? (f * factorial(f - 1)) : 1;
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

            foreach(BigInteger b in list)
            {
                sum += b;
            }

            return sum;
        }
    }
}

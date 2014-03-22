using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
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

        public static Boolean IsPalindrome(this String str)
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
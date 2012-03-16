using System;
using System.Linq;
using System.Numerics;

/*
 * 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
 * 
 * Find the sum of all numbers which are equal to the sum of the factorial of their digits.
*/
namespace ProjectEuler
{
    class Euler34 : EulerProblem
    {
        public override object Solution()
        {
            return Enumerable.Range(3, 100000).Where(s => Check(s)).Sum();
        }

        Boolean Check(BigInteger bi)
        {
            BigInteger sum = 0;

            foreach (var c in bi.ToString())
            {
                sum += BigInteger.Parse(c + "").Factorial();
            }

            return bi == sum;
        }
    }
}
